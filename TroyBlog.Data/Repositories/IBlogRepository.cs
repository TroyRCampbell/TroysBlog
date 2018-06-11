using System.Linq;

namespace TroysBlog.Data.Repositories
{
    public interface IBlogRepository
    {
        IQueryable<Blog> GetBlogs(bool active);
    }
}