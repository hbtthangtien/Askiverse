using Application.DTOs.Forum;
using Application.Interface.IRepository;
using Application.Paginated;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ForumPostRepository : Repository<ForumPost>, IForumPostRepository
    {
        private readonly AskiverseContext _context;

        public ForumPostRepository(AskiverseContext context) : base(context)
        {
            _context = context;
        }


        public async Task<PaginatedList<ForumPost>> GetFilteredPostsAsync(ForumPostFilterDTO filter)
        {
            var query = _context.ForumPosts
                .Include(p => p.Subject)
                .Include(p => p.QuestionExam).ThenInclude(q => q.BankQuestion)
                .Include(p => p.CreatedBy)
                .Include(p => p.Comments)
                .Include(p => p.Voteds)
                .Where(p => p.DeletedAt == null && p.ForumStatus == ForumStatus.Approved)
                .AsQueryable();

            if (filter.SubjectId.HasValue)
                query = query.Where(p => p.SubjectId == filter.SubjectId.Value);

            if (!string.IsNullOrWhiteSpace(filter.Keyword))
            {
                var keyword = filter.Keyword.ToLower();
                query = query.Where(p =>
                    (!string.IsNullOrEmpty(p.Title) && p.Title.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.HeadLine) && p.HeadLine.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.Content) && p.Content.ToLower().Contains(keyword))
                );
            }

            query = filter.SortOrder == "oldest"
                ? query.OrderBy(p => p.CreatedAt)
                : query.OrderByDescending(p => p.CreatedAt);

            return await PaginatedList<ForumPost>.CreateAsync(query, filter.PageIndex, filter.PageSize);
        }
        public async Task<PaginatedList<ForumPost>> GetMyPostsAsync(ForumPostFilterDTO filter)
        {
            var query = _context.ForumPosts
                .Include(p => p.Subject)
                .Include(p => p.QuestionExam).ThenInclude(q => q.BankQuestion)
                .Include(p => p.CreatedBy)
                .Include(p => p.Comments)
                .Include(p => p.Voteds)
                .Where(p => p.CreatedById == filter.CreatedById)
                .AsQueryable();

            if (filter.SubjectId.HasValue)
                query = query.Where(p => p.SubjectId == filter.SubjectId.Value);

            if (filter.ForumStatus.HasValue) 
                query = query.Where(p => p.ForumStatus == filter.ForumStatus.Value);

            if (!string.IsNullOrWhiteSpace(filter.Keyword))
            {
                var keyword = filter.Keyword.ToLower();
                query = query.Where(p =>
                    (!string.IsNullOrEmpty(p.Title) && p.Title.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.HeadLine) && p.HeadLine.ToLower().Contains(keyword)) ||
                    (!string.IsNullOrEmpty(p.Content) && p.Content.ToLower().Contains(keyword))
                );
            }

            query = filter.SortOrder == "oldest"
                ? query.OrderBy(p => p.CreatedAt)
                : query.OrderByDescending(p => p.CreatedAt);

            return await PaginatedList<ForumPost>.CreateAsync(query, filter.PageIndex, filter.PageSize);
        }


        public async Task<ForumPost?> GetPostDetailAsync(int postId)
        {
            return await _context.ForumPosts
       .Include(p => p.Subject)
       .Include(p => p.CreatedBy)
           .ThenInclude(u => u.Profile) // 👈 THÊM DÒNG NÀY
       .Include(p => p.Comments)
           .ThenInclude(c => c.User)
               .ThenInclude(u => u.Profile) // để hiển thị tên người bình luận
       .Include(p => p.Voteds)
           .ThenInclude(v => v.VotedBy)
       .FirstOrDefaultAsync(p => p.Id == postId);
        }
        public async Task<ForumPost?> GetByIdAsync(int id)
        {
            return await _context.ForumPosts
                .Include(p => p.Subject)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task UpdateAsync(ForumPost post)
        {
            _context.ForumPosts.Update(post);
            await _context.SaveChangesAsync();
        }

        public async Task SoftDeleteAsync(int id)
        {
            var post = await _context.ForumPosts.FindAsync(id);
            if (post != null && post.DeletedAt == null)
            {
                _context.ForumPosts.Remove(post); // sẽ trigger soft delete
                await _context.SaveChangesAsync();
            }
        }
    }

}
