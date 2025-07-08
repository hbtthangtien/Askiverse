using Application.DTOs.Forum;
using Application.Interface.IRepository;
using Application.Interface.IServices;
using Application.Paginated;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ForumPostService : Service, IForumPostService
    {
        private readonly IForumPostRepository _forumPostRepo;
        private readonly IForumCommentRepository _forumCommentRepository;

        public ForumPostService(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
            _forumPostRepo = unitOfWork.ForumPosts;
            _forumCommentRepository = unitOfWork.ForumComments;
        }

        public Task<PaginatedList<ForumPost>> GetFilteredForumPostsAsync(ForumPostFilterDTO filter)
        => _forumPostRepo.GetFilteredPostsAsync(filter);

        public Task<PaginatedList<ForumPost>> GetMyForumPostsAsync(ForumPostFilterDTO filter)
            => _forumPostRepo.GetMyPostsAsync(filter);
        public async Task CreatePostAsync(CreateForumPostDTO dto, string userId)
        {
            var post = _mapper.Map<ForumPost>(dto);
            post.CreatedById = userId;
            post.CreatedAt = DateTime.UtcNow;
            post.UpdatedAt = DateTime.UtcNow;
            post.ForumStatus = ForumStatus.Approved;
            post.IsPinned = false;

            await _unitOfWork.ForumPosts.AddAsync(post);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<ForumPost?> GetPostDetailAsync(int postId)
        {
            return await _unitOfWork.ForumPosts.GetPostDetailAsync(postId);
        }
        public async Task AddCommentAsync(string userId, int postId, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return;

            var comment = new ForumComment
            {
                PostId = postId,
                UserId = userId,
               
                Content = content,
                CommentedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _unitOfWork.ForumComments.AddAsync(comment);
            await _unitOfWork.CompleteAsync();
        }

        public async Task VoteAsync(string userId, int postId, VoteType voteType)
        {
            var existing = await _unitOfWork.ForumVoteds.GetByUserAndPostAsync(userId, postId);

            if (existing == null)
            {
                // Chưa vote → thêm mới
                var vote = new ForumVoted
                {
                    PostId = postId,
                    VotedById = userId,
                    VotedType = voteType,
                    VotedAt = DateTime.Now
                };

                await _unitOfWork.ForumVoteds.AddAsync(vote);
            }
            else if (existing.VotedType == voteType)
            {
                // Đã vote cùng loại → toggle (xóa vote)
                _unitOfWork.ForumVoteds.Remove(existing);
            }
            else
            {
                // Đã vote khác loại → cập nhật sang loại mới
                existing.VotedType = voteType;
                existing.VotedAt = DateTime.Now;
                _unitOfWork.ForumVoteds.UpdateAsync(existing);
            }

            await _unitOfWork.CompleteAsync();
        }
        public async Task<ForumPost?> GetPostByIdAsync(int id)
        {
            return await _forumPostRepo.GetByIdAsync(id);
        }
        public async Task UpdatePostAsync(ForumPost post)
        {
            post.UpdatedAt = DateTime.UtcNow;
            await _forumPostRepo.UpdateAsync(post);
        }

        public async Task SoftDeletePostAsync(int id)
        {
            await _forumPostRepo.SoftDeleteAsync(id);
        }
        public async Task EditCommentAsync(int commentId, string userId, string newContent)
        {
            var comment = await _unitOfWork.ForumComments.GetByIdAsync(commentId);

            if (comment == null || comment.DeletedAt != null)
                throw new Exception("Bình luận không tồn tại hoặc đã bị xoá.");

            if (comment.UserId != userId)
                throw new Exception("Bạn không có quyền sửa bình luận này.");

            comment.Content = newContent;
            comment.UpdatedAt = DateTime.Now;

            await _unitOfWork.CompleteAsync();
        }
        public async Task DeleteCommentAsync(int commentId, string userId)
        {
            var comment = await _unitOfWork.ForumComments.GetByIdAsync(commentId);

            if (comment == null || comment.DeletedAt != null)
                throw new Exception("Bình luận không tồn tại hoặc đã bị xoá.");

            if (comment.UserId != userId)
                throw new Exception("Bạn không có quyền xoá bình luận này.");

           await _forumCommentRepository.SoftDeleteAsync(comment.Id); 

            await _unitOfWork.CompleteAsync();
        }

    }

}
