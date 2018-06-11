using System.Collections.Generic;
using System.Linq;
using TroysBlog.Data;
using TroysBlog.Data.Repositories;

namespace TroysBlog.Services
{
    public class CommentService : ICommentService
    {
        private ICommentRepository commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public List<Comment> GetComments()
        {
            return this.commentRepository.GetComments()
                .OrderBy(c => c.AuthoredOn)
                .ToList();
        }

        public List<Comment> GetCommentsByBlogId(int blogId)
        {
            return this.commentRepository.GetCommentsByBlogId(blogId)
                .OrderBy(c => c.AuthoredOn)
                .ToList();
        }

        public List<Comment> GetRecentComments(int count)
        {
            return this.GetComments()
                .OrderByDescending(c => c.AuthoredOn)
                .Take(count)
                .ToList();
        }
    }
}