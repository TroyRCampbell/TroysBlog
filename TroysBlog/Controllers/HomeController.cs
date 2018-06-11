using System.Web.Mvc;
using TroysBlog.Models.ViewModels;
using TroysBlog.Services;

namespace TroysBlog.Controllers
{
    public class HomeController : Controller
    {
        private IBlogService blogService;
        private ICommentService commentService;

        public HomeController(IBlogService blogService, ICommentService commentService)
        {
            this.blogService = blogService;
            this.commentService = commentService;
        }

        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel()
            {
                Blogs = this.blogService.GetBlogs(active: true),
                RecentComments = this.commentService.GetRecentComments(5)
            };

            return View(model);
        }
    }
}