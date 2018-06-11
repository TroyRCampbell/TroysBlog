using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using TroysBlog.Controllers;
using TroysBlog.Services;

namespace TroysBlog.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var blogService = Substitute.For<IBlogService>();
            var commentService = Substitute.For<ICommentService>();
            HomeController controller = new HomeController(blogService, commentService);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
