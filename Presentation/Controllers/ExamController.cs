using Application.DTOs.Exam;
using Application.DTOs.Question;
using Application.Interface.IServices;
using Domain.Entities;
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
            var allQuestions = await _examService.SearchBankQuestionsAsync(new SearchBankQuestionFilter(), userId);
            ViewBag.Subjects = subjects;
            ViewBag.QuestionTypes = questionTypes;
            ViewBag.Levels = levels;
            ViewBag.InitialQuestions = allQuestions;
            return View(new CreateExamDTO());
        }

        [Authorize]
        [HttpPost]
        public IActionResult GetExamTakeById(int examId)
        {
			HttpContext.Session.SetInt32("CurrentExamId", examId);
			return RedirectToAction("TakeExam");
        }

        [HttpGet]
        public async Task<IActionResult> TakeExam()
        {
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (userId == null) return Unauthorized();

			var examId = HttpContext.Session.GetInt32("CurrentExamId");
			if (examId == null) return RedirectToAction("AllExams");

            var examScored = HttpContext.Session.GetInt32("ExamScoredId");
            if(examScored == null)
            {
                examScored = await _examService.CreateExamScoredAsync(examId.Value, userId);
                HttpContext.Session.SetInt32("ExamScoredId", examScored.Value);
            }

			var exam = await _examService.GetExamTakeById(examId.Value, userId);
			if (exam == null) return NotFound();
            exam.ExanScoredId = examScored.Value;

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

            dto.PremiumUserId = userId;

            if (!ModelState.IsValid)
            {
                await PrepareViewBagDataForCreatePage();
                Console.WriteLine("IsValid: " + ModelState.IsValid);
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine("❌ ModelState error: " + error.ErrorMessage);
                }

                return View(dto); // ❌ Trường hợp tạo thất bại: quay lại View kèm ModelState
            }

            try
            {
                var examId = await _examService.CreateExamAsync(dto);
                TempData["Success"] = "Đề thi đã được tạo thành công!";
                TempData["RedirectToPreview"] = examId;

                return RedirectToAction("Create"); 



            }

            catch (Exception ex)
            {
                await PrepareViewBagDataForCreatePage();
                TempData["Error"] = ex.InnerException?.Message ?? ex.Message;
                return View(dto);
            }
        }


        // Gợi ý tạo hàm riêng để không lặp code
        private async Task PrepareViewBagDataForCreatePage()
        {
            var userId = GetCurrentUserId();
            ViewBag.Subjects = await _examService.GetAllSubjectsAsync();
            ViewBag.QuestionTypes = await _examService.GetAllQuestionTypesAsync();
            ViewBag.Levels = await _examService.GetAllLevelsAsync();

            var allQuestions = await _examService.SearchBankQuestionsAsync(new SearchBankQuestionFilter(), userId);
            ViewBag.InitialQuestions = allQuestions;
            ViewBag.CurrentPage = 1;
            ViewBag.TotalPages = 1;
        }


        [HttpGet]
        public async Task<IActionResult> SearchQuestions(int? questionTypeId, int? levelId, bool? isPublic, string? keyword, int page = 1, int pageSize = 10)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrWhiteSpace(keyword))
                keyword = null;

            var filter = new SearchBankQuestionFilter
            {
                QuestionTypeId = questionTypeId,
                LevelId = levelId,
                IsPublic = isPublic,
                Keyword = keyword
            };

            var allResults = await _examService.SearchBankQuestionsAsync(filter, userId);
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitExam(ExamSubmitDTO dto, int ExamScoredId)
        {
			HttpContext.Session.Remove("CurrentExamId");
			HttpContext.Session.Remove("ExamScoredId");
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
        [Authorize]
        public async Task<IActionResult> AllExams(bool isPublic = true, string subjectId = "", bool isFavourite = false)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var exams = await _examService.GetAllExams(isPublic, userId!, subjectId, isFavourite);

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
        public async Task<IActionResult> GetRandomQuestionIds(int count, int? questionTypeId, int? levelId, string? keyword)
        {
            var filter = new SearchBankQuestionFilter
            {
                QuestionTypeId = questionTypeId,
                LevelId = levelId,
                Keyword = string.IsNullOrWhiteSpace(keyword) ? null : keyword
            };

            var userId = GetCurrentUserId();
            var ids = await _examService.GetRandomQuestionIdsAsync(count, filter, userId);

            return Json(ids);
        }

        [HttpGet]
        public async Task<IActionResult> GetExamsByPremiumUserId()
        {
            var userId = GetCurrentUserId();

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var exams = await _examService.GetExamsByPremiumUserIdAsync(userId);
            return Json(exams);
        }


        [HttpPost]
        public async Task<IActionResult> GrantExamAccessByEmail([FromBody] GrantExamAccessDTO dto)
        {
            var userId = GetCurrentUserId();
            var result = await _examService.GrantExamAccessAsync(dto, userId!);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            return Ok(result.Message);
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> PreviewExam(int examId)
        {
            var userId = GetCurrentUserId();
            if (userId == null) return Unauthorized();

            var exam = await _examService.GetExamTakeById(examId, userId);
            if (exam == null) return NotFound();

            return View("PreviewExam", exam); // View mới
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteExam(int examId)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var success = await _examService.DeleteExamAsync(examId, userId!);
                if (!success)
                {
                    TempData["Error"] = "Đề thi không tồn tại.";
                    return RedirectToAction("AllExams");
                }

                TempData["Success"] = "Đã xóa đề thi thành công.";
                return RedirectToAction("AllExams");
            }
            catch (InvalidOperationException ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("AllExams");
            }
        }



        [HttpGet]
        public async Task<IActionResult> CreateExamQuestion()
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            var questionTypes = await _examService.GetAllQuestionTypesAsync();
            var levels = await _examService.GetAllLevelsAsync();

            ViewBag.QuestionTypes = new SelectList(questionTypes, "Id", "Name");
            ViewBag.Levels = new SelectList(levels, "Id", "DisplayName");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateExamQuestion(CreateBankQuestionDTO dto)
        {
            var userId = GetCurrentUserId();
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "BasicUser");
            }
            dto.Answers = dto.Answers
                .Where(a => !a.IsDeleted)
                .ToList();
            dto.PremiumUserId = userId;
            if (!ModelState.IsValid)
            {
                var questionTypes = await _examService.GetAllQuestionTypesAsync();
                var levels = await _examService.GetAllLevelsAsync();

                ViewBag.QuestionTypes = new SelectList(questionTypes, "Id", "Name");
                ViewBag.Levels = new SelectList(levels, "Id", "DisplayName");

                // Debug lỗi
                foreach (var key in ModelState.Keys)
                {
                    var errors = ModelState[key].Errors;
                    foreach (var error in errors)
                    {
                        Console.WriteLine($"Model Error for {key}: {error.ErrorMessage}");
                    }
                }

                return View(dto);
            }

            await _examService.CreateBankQuestionAsync(dto);
            TempData["Success"] = "Đã tạo câu hỏi thành công!";
            return RedirectToAction("Create");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int examId)
        {
            var userId = GetCurrentUserId();
            var model = await _examService.GetExamForEditAsync(examId);

            // Load ViewBag
            await PrepareViewBagDataForCreatePage(); // dùng lại từ Create

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditExamDTO dto)
        {
            if (!ModelState.IsValid)
            {
                await PrepareViewBagDataForCreatePage();
                return View(dto);
            }

            try
            {
                await _examService.UpdateExamAsync(dto);
                TempData["Success"] = "Cập nhật đề thành công.";
                return RedirectToAction("AllExams");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("AllExams"); // hoặc trang bạn hiển thị danh sách đề
            }

        }


    }
}
