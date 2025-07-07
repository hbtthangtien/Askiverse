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
                .Where(c => c.PostId == postId)
                .OrderByDescending(c => c.CommentedAt)
                .Include(c => c.User)
                    .ThenInclude(u => u.Profile);

            return await PaginatedList<ForumComment>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
