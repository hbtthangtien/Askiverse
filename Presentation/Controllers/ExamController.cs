using Application.DTOs.Exam;
using Application.Interface.IServices;
using Microsoft.AspNetCore.Authorization;


using Microsoft.AspNetCore.Mvc;
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
            if (dto.SelectedQuestionIds == null || dto.SelectedQuestionIds.Count != dto.TotalQuestion)
            {
                ModelState.AddModelError("", $"Bạn phải chọn đúng {dto.TotalQuestion} câu hỏi.");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Subjects = await _examService.GetAllSubjectsAsync();
                var allQuestions = await _examService.SearchBankQuestionsAsync(new SearchBankQuestionFilter());
                ViewBag.InitialQuestions = allQuestions;


                return View(dto);
            }



            try
            {
                await _examService.CreateExamAsync(dto);
                return RedirectToAction("Create");
            }
            catch (Exception ex)
            {
                ViewBag.Subjects = await _examService.GetAllSubjectsAsync();
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }


        [HttpGet]
        public async Task<IActionResult> SearchQuestions(int? questionTypeId, int? levelId, bool? isPublic, string? keyword)
        {
            // Nếu keyword là chuỗi rỗng, chuyển thành null
            if (string.IsNullOrWhiteSpace(keyword))
                keyword = null;

            var filter = new SearchBankQuestionFilter
            {
                QuestionTypeId = questionTypeId,
                LevelId = levelId,
                IsPublic = isPublic,
                Keyword = keyword
            };

            var results = await _examService.SearchBankQuestionsAsync(filter);
            return PartialView("_SearchQuestionResults", results);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitExam(ExamSubmitDTO dto, int ExamScoredId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized();

            try
            {
                var examScoredId = await _examService.SubmitExamAsync(dto, ExamScoredId);

                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new
                    {
                        success = true,
                        examScoredId = examScoredId,
                        examId = dto.ExamId
                    });
                }
                ViewData["examScoredId"] = examScoredId;
                ViewData["ExamId"] = dto.ExamId;
                return View("SubmitExam");
            }
            catch (Exception ex)
            {
                if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    return Json(new
                    {
                        success = false,
                        error = ex.Message
                    });
                }
                ViewData["Error"] = ex.Message;
                return View("SubmitExam");
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
    }
}
