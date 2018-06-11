using System.Data.Entity;
using System.Linq;
using TroysBlog.Data;

namespace TroysBlog.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        TroysBlogEntities entities = new TroysBlogEntities();

        public DbSet<Comment> GetComments()
        {
            return entities.Comments;
        }

        public IQueryable<Comment> GetCommentsByBlogId(int blogId)
        {
            return entities.Comments.Where(b => b.BlogId == blogId);
        }
    }
}