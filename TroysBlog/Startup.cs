using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using TroysBlog.Models;

[assembly: OwinStartupAttribute(typeof(TroysBlog.Startup))]
namespace TroysBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }

        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
   
            if (!roleManager.RoleExists("Admin"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);
            }
  
            if (!roleManager.RoleExists("Reader"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Reader";
                roleManager.Create(role);
            }

            var user = UserManager.FindByEmail("trcjrc@gmail.com");
            if (user == null)
            {
                user = new ApplicationUser()
                {
                    UserName = "TroyC",
                    Email = "trcjrc@gmail.com"
                };

                UserManager.Create(user, "Tr0yC1!");
                UserManager.AddToRole(user.Id, "Admin");
            }
            else
            {
                if (!UserManager.IsInRole(user.Id, "Admin"))
                {
                    UserManager.AddToRole(user.Id, "Admin");
                }
            }
        }
    }
}
