using System.Security.Claims;
using Application.DTOs.Forum;
using Application.DTOs.ViewModel;
using Application.Interface.IServices;
using Application.Paginated;
using Application.Services;
using Domain.Entities;
using Domain.Enums;
using iText.StyledXmlParser.Jsoup.Nodes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForumPostService _forumService;
        private readonly IExamService _examService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IForumCommentService _forumCommentService;
        public ForumController(
            IForumPostService forumService,
           IExamService examService, IHttpContextAccessor httpContextAccessor, IForumCommentService forumCommentService)
        {
            _forumService = forumService;
            _examService = examService;
            _httpContextAccessor = httpContextAccessor;
            _forumCommentService = forumCommentService;
        }
        private string? GetCurrentUserId()
        {
            return _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public async Task<IActionResult> Index(ForumPostFilterDTO filter)
        {
            var posts = await _forumService.GetFilteredForumPostsAsync(filter);

            var subjects = await _examService.GetAllSubjectsAsync();

            ViewBag.Subjects = new SelectList(subjects, "Id", "Name");

            return View(posts);
        }


        private async Task<List<Subject>> GetSubjectsAsync()
        {
            return await _examService.GetAllSubjectsAsync();
        }

        private async Task<List<QuestionType>> GetQuestionTypesAsync()
        {
            return await _examService.GetAllQuestionTypesAsync();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            var subjects = await _examService.GetAllSubjectsAsync();
            var questionTypes = await _examService.GetAllQuestionTypesAsync();

            ViewBag.Subjects = new SelectList(subjects, "Id", "Name");
            ViewBag.QuestionTypes = new SelectList(questionTypes, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateForumPostDTO dto)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }

            if (!ModelState.IsValid)
            {
                var subjects = await _examService.GetAllSubjectsAsync();
                var questionTypes = await _examService.GetAllQuestionTypesAsync();

                ViewBag.Subjects = new SelectList(subjects, "Id", "Name");

                return View(dto);
            }

            await _forumService.CreatePostAsync(dto, userId);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int id, int page = 1)
        {
            var post = await _forumService.GetPostDetailAsync(id);
            if (post == null) return NotFound();

            var userId = GetCurrentUserId();
            var userVote = post.Voteds.FirstOrDefault(v => v.VotedById == userId);
            ViewBag.UserVoteType = userVote?.VotedType;

            const int pageSize = 5;

            // 🔥 KHÔNG dùng post.Comments ở đây
            var pagedComments = await _forumCommentService.GetPagedCommentsAsync(id, page, pageSize);

            var viewModel = new ForumPostDetailViewModel
            {
                ForumPost = post,
                PaginatedComments = pagedComments
            };

            return View(viewModel);
        }





        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddComment(int postId, string content)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            await _forumService.AddCommentAsync(userId, postId, content);
            return RedirectToAction("Detail", new { id = postId });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Vote(int postId, VoteType voteType)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            await _forumService.VoteAsync(userId, postId, voteType);
            return RedirectToAction("Detail", new { id = postId });
        }
        public async Task<IActionResult> MyPosts(ForumPostFilterDTO filter)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            filter.CreatedById = userId;

            var posts = await _forumService.GetMyForumPostsAsync(filter);

            ViewBag.Subjects = new SelectList(await _examService.GetAllSubjectsAsync(), "Id", "Name");

            ViewBag.ForumStatuses = Enum.GetValues(typeof(ForumStatus))
                .Cast<ForumStatus>()
                .Select(s => new SelectListItem
                {
                    Value = ((int)s).ToString(),
                    Text = s.ToString()
                })
                .ToList();

            return View(posts);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            var post = await _forumService.GetPostByIdAsync(id);
            if (post == null || post.DeletedAt != null)
                return NotFound();

            var dto = new UpdateForumPostDTO
            {
                Id = post.Id,
                Title = post.Title,
                HeadLine = post.HeadLine,
                Content = post.Content,
                SubjectId = post.SubjectId,
                ForumStatus = post.ForumStatus,
                ImgUrl = post.ImgUrl 
            };


            ViewBag.Subjects = new SelectList(await _examService.GetAllSubjectsAsync(), "Id", "Name");
            return View(dto);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, UpdateForumPostDTO model)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            if (id != model.Id)
                return BadRequest();

            ViewBag.Subjects = new SelectList(await _examService.GetAllSubjectsAsync(), "Id", "Name");

            if (!ModelState.IsValid)
                return View(model);

            var post = await _forumService.GetPostByIdAsync(id);
            if (post == null || post.DeletedAt != null)
                return NotFound();

            post.Title = model.Title;
            post.HeadLine = model.HeadLine;
            post.Content = model.Content;
            post.SubjectId = model.SubjectId;
            post.ForumStatus = model.ForumStatus;
            post.ImgUrl = model.ImgUrl; 


            await _forumService.UpdatePostAsync(post);

            TempData["SuccessMessage"] = "✅ Bài viết đã được cập nhật!";
            return RedirectToAction("Edit", new { id = post.Id });

        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            var post = await _forumService.GetPostByIdAsync(id);
            if (post == null || post.DeletedAt != null)
                return NotFound();

            await _forumService.SoftDeletePostAsync(id);
            TempData["SuccessMessage"] = "🗑️ Bài viết đã được xóa!";
            return RedirectToAction("MyPosts");
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditComment(int commentId, string content, int postId)
        {
            var userId = GetCurrentUserId();
            await _forumService.EditCommentAsync(commentId, userId, content);
            return RedirectToAction("Detail", new { id = postId });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteComment(int commentId, int postId)
        {
            var userId = GetCurrentUserId();
            await _forumService.DeleteCommentAsync(commentId, userId);
            return RedirectToAction("Detail", new { id = postId });

        }


    }

}
