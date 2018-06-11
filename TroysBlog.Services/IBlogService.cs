using System.Collections.Generic;
using TroysBlog.Models.ViewModels;

namespace TroysBlog.Services
{
    public interface IBlogService
    {
        List<BlogViewModel> GetBlogs(bool active);
    }
}