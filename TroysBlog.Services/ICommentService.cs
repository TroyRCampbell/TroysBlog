using System.Collections.Generic;
using TroysBlog.Data;

namespace TroysBlog.Services
{
    public interface ICommentService
    {
        List<Comment> GetComments();
        List<Comment> GetCommentsByBlogId(int blogId);
        List<Comment> GetRecentComments(int count);
    }
}