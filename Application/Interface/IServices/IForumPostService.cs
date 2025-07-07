using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Forum;
using Application.Paginated;
using Domain.Entities;
using Domain.Enums;

namespace Application.Interface.IServices
{
    public interface IForumPostService
    {
        Task<PaginatedList<ForumPost>> GetFilteredForumPostsAsync(ForumPostFilterDTO filter);
        Task CreatePostAsync(CreateForumPostDTO dto, string userId);
        Task<ForumPost?> GetPostDetailAsync(int postId);
        Task AddCommentAsync(string userId, int postId, string content);
        Task VoteAsync(string userId, int postId, VoteType voteType);
        Task<PaginatedList<ForumPost>> GetMyForumPostsAsync(ForumPostFilterDTO filter);
        Task<ForumPost?> GetPostByIdAsync(int id);
        Task UpdatePostAsync(ForumPost post);
        Task SoftDeletePostAsync(int id);
        Task EditCommentAsync(int commentId, string userId, string newContent);
        Task DeleteCommentAsync(int commentId, string userId);
    }

}
