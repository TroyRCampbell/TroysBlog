using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TroysBlog.Startup))]
namespace TroysBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
