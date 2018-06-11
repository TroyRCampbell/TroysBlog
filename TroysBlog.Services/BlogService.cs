using System.Collections.Generic;
using System.Linq;
using TroysBlog.Data.Repositories;
using TroysBlog.Models.ViewModels;

namespace TroysBlog.Services
{
    public class BlogService : IBlogService
    {
        private IBlogRepository blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public List<BlogViewModel> GetBlogs(bool active)
        {
            return blogRepository.GetBlogs(active)
                .Select(b => new BlogViewModel()
                {
                    Blog = b
                })
                .ToList();
        }
    }
}