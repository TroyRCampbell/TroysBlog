using System.Collections.Generic;
using TroysBlog.Data;

namespace TroysBlog.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<BlogViewModel> Blogs { get; set; }

        public List<Comment> RecentComments { get; set; }
    }
}