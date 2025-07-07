using Application.Interface.IRepository;
using Application.Paginated;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ForumCommentRepository : Repository<ForumComment>, IForumCommentRepository
    {
        public ForumCommentRepository(AskiverseContext context) : base(context)
        {
        }
        public async Task<PaginatedList<ForumComment>> GetPagedCommentsByPostIdAsync(int postId, int pageIndex, int pageSize)
        {
            var query = _context.ForumComments
                .Include(c => c.User)
                    .ThenInclude(u => u.Profile)
                .Where(c => c.PostId == postId && c.DeletedAt == null)
                .OrderByDescending(c => c.CommentedAt);

            return await PaginatedList<ForumComment>.CreateAsync(query, pageIndex, pageSize);
        }

        public async Task<ForumComment?> GetByIdAsync(int id)
        {
            return await _context.ForumComments
                .Include(c => c.User) 
                .Include(c => c.Post) 
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task SoftDeleteAsync(int id)
        {
            var post = await _context.ForumComments.FindAsync(id);
            if (post != null && post.DeletedAt == null)
            {
                _context.ForumComments.Remove(post); // sẽ trigger soft delete
                await _context.SaveChangesAsync();
            }
        }
    }
}
