using Application.DTOs.Exam;
using Application.DTOs.Question;
using Application.Interface.IServices;
using Microsoft.AspNetCore.Authorization;


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Presentation.Controllers
{
    public class ExamController : Controller
    {
        private readonly IExamService _examService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ExamController(IExamService examService, IHttpContextAccessor httpContextAccessor)
        {
            _examService = examService;
            _httpContextAccessor = httpContextAccessor;
        }
        private string? GetCurrentUserId()
        {
            return _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
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
            var levels = await _examService.GetAllLevelsAsync();
            var allQuestions = await _examService.SearchBankQuestionsAsync(new SearchBankQuestionFilter());
            ViewBag.Subjects = subjects;
            ViewBag.QuestionTypes = questionTypes;
            ViewBag.Levels = levels;
            ViewBag.InitialQuestions = allQuestions;
            return View(new CreateExamDTO());
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> GetExamTakeById(int examId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized();

            if (userId == null) return Unauthorized();

            var exam = await _examService.GetExamTakeById(examId, userId);

            if (exam == null) return NotFound();

            return View("ExamTakeView", exam);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateExamDTO dto)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            Console.WriteLine("✅ Số câu được gửi: " + dto.SelectedQuestionIds?.Count);

            // Validate số lượng câu hỏi
            if (dto.SelectedQuestionIds == null || dto.SelectedQuestionIds.Count != dto.TotalQuestion)
            {
                ModelState.AddModelError("", $"Bạn phải chọn đúng {dto.TotalQuestion} câu hỏi.");
            }

            if (!ModelState.IsValid)
            {
                // Nạp lại dữ liệu cho ViewBag để không lỗi View khi load lại
                await PrepareViewBagDataForCreatePage();

                return View(dto);
            }

            try
            {
                await _examService.CreateExamAsync(dto);
                return RedirectToAction("Create");
            }
            catch (Exception ex)
            {
                await PrepareViewBagDataForCreatePage();
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }

        // Gợi ý tạo hàm riêng để không lặp code
        private async Task PrepareViewBagDataForCreatePage()
        {
            ViewBag.Subjects = await _examService.GetAllSubjectsAsync();
            ViewBag.QuestionTypes = await _examService.GetAllQuestionTypesAsync();
            ViewBag.Levels = await _examService.GetAllLevelsAsync();

            var allQuestions = await _examService.SearchBankQuestionsAsync(new SearchBankQuestionFilter());
            ViewBag.InitialQuestions = allQuestions;
            ViewBag.CurrentPage = 1;
            ViewBag.TotalPages = 1;
        }


        [HttpGet]
        public async Task<IActionResult> SearchQuestions(int? questionTypeId, int? levelId, bool? isPublic, string? keyword, int page = 1, int pageSize = 10)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                keyword = null;

            var filter = new SearchBankQuestionFilter
            {
                QuestionTypeId = questionTypeId,
                LevelId = levelId,
                IsPublic = isPublic,
                Keyword = keyword
            };

            var allResults = await _examService.SearchBankQuestionsAsync(filter); 
            var total = allResults.Count;

            var paginated = allResults
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPages = (int)Math.Ceiling((double)total / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;

            return PartialView("_SearchQuestionResults", paginated);
        }




        [HttpGet]
	public async Task<IActionResult> GetQuestionDetail(int id)
	{
		var detail = await _examService.GetQuestionDetailAsync(id);

            if (detail == null)
                return NotFound();

            return Json(detail);
        }

        [Authorize]
        public async Task<IActionResult> AllExams(bool isPublic = true, string subjectId = "")
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var exams = await _examService.GetAllExams(isPublic, userId!, subjectId);

                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView("_ExamListPartial", exams);
                }

                return View(exams);
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return PartialView("_ExamListPartial");
            }
        }

         [Authorize]
         [Authorize]
        public async Task<IActionResult> AllExams(bool isPublic = true, string subjectId = "")
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var exams = await _examService.GetAllExams(isPublic, userId!, subjectId);

                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return PartialView("_ExamListPartial", exams);
                }

                return View(exams);
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return PartialView("_ExamListPartial");
            }
        }

	   [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitExamResult(int? examScoredId, int? examId, string? error)
        {
            if (!string.IsNullOrEmpty(error))
            {
                ViewData["Error"] = error;
            }
            else
            {
                ViewData["examScoredId"] = examScoredId;
                ViewData["ExamId"] = examId;
            }
            return View("SubmitExam");
        }
        [HttpGet]
        public async Task<IActionResult> EditExamQuestion(int id)
        {
            var question = await _examService.GetBankQuestionByIdAsync(id);
            if (question == null) return NotFound();

            var questionTypes = await _examService.GetAllQuestionTypesAsync();
            var levels = await _examService.GetAllLevelsAsync();

            ViewBag.QuestionTypes = new SelectList(questionTypes, "Id", "Name");
            ViewBag.Levels = new SelectList(levels, "Id", "DisplayName");

            var dto = new UpdateBankQuestionDTO
            {
                Id = question.Id,
                Content = question.Content,
                QuestionTypeId = question.QuestionTypeId,
                LevelId = question.LevelId,
                IsPublic = question.IsPublic,
                Answers = question.Answers.Select(a => new UpdateAnswerDTO
                {
                    Id = a.Id,
                    AnswerText = a.AnswerText,
                    IsCorrected = a.IsCorrected,
                    MatchingPairKey = a.MatchingPairKey
                }).ToList()
            };

            return View("EditExamQuestion", dto);
        }

        [HttpPost]
        public async Task<IActionResult> EditExamQuestion(UpdateBankQuestionDTO dto)
        {
            if (!ModelState.IsValid)
            {
                var questionTypes = await _examService.GetAllQuestionTypesAsync();
                var levels = await _examService.GetAllLevelsAsync();

                ViewBag.QuestionTypes = new SelectList(questionTypes, "Id", "Name");
                ViewBag.Levels = new SelectList(levels, "Id", "DisplayName");

                return View("EditExamQuestion", dto);
            }

            await _examService.UpdateBankQuestionAsync(dto);
            return RedirectToAction("Create"); 
        }

        [HttpGet]
        public async Task<IActionResult> GetRandomQuestionIds(int count, int? questionTypeId, int? levelId, bool? isPublic, string? keyword)
        {
            var filter = new SearchBankQuestionFilter
            {
                QuestionTypeId = questionTypeId,
                LevelId = levelId,
                IsPublic = isPublic,
                Keyword = string.IsNullOrWhiteSpace(keyword) ? null : keyword
            };

            var ids = await _examService.GetRandomQuestionIdsAsync(count, filter);

            return Json(ids);
        }

    }
}
