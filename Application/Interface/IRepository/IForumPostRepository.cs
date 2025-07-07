using Application.DTOs.Forum;
using Application.Paginated;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IForumPostRepository : IRepository<ForumPost>
    {
        Task<PaginatedList<ForumPost>> GetFilteredPostsAsync(ForumPostFilterDTO filter);
        Task<ForumPost?> GetPostDetailAsync(int postId);
        Task<PaginatedList<ForumPost>> GetMyPostsAsync(ForumPostFilterDTO filter);
        Task<ForumPost?> GetByIdAsync(int id);
        Task UpdateAsync(ForumPost post);
        Task SoftDeleteAsync(int id);
    }
}
