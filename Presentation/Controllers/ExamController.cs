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

        public ExamController(IExamService examService)
        {
            _examService = examService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
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


        [HttpPost]
        public async Task<IActionResult> Create(CreateExamDTO dto)
        {
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
        public async Task<IActionResult> AllExams()
        {
            var exams = await _examService.GetAllExams();
            return View(exams);
        }

        [Authorize]
        public async Task<IActionResult> GetExamTakeById(int examId)
        {
            var exam = await _examService.GetExamTakeById(examId);

            if (exam == null) return NotFound();

            return View("ExamTakeView", exam);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitExam(ExamSubmitDTO dto)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null) return Unauthorized();

            try
            {
                var examScoredId = await _examService.SubmitExamAsync(dto, userId);
                ViewData["examScoredId"] = examScoredId;
                ViewData["ExamId"] = dto.ExamId;
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
            }
            return View("SubmitExam");
        }

    }

}
