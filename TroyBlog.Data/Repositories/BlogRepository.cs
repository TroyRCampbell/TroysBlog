using System.Linq;

namespace TroysBlog.Data.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        TroysBlogEntities entities = new TroysBlogEntities();

        public IQueryable<Blog> GetBlogs(bool active)
        {
            return entities.Blogs.Where(b => b.Active == active);
        }
    }
}