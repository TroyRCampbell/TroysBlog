using System.Data.Entity;
using System.Linq;

namespace TroysBlog.Data.Repositories
{
    public interface ICommentRepository
    {
        DbSet<Comment> GetComments();
        IQueryable<Comment> GetCommentsByBlogId(int blogId);
    }
}