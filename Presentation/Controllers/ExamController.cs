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

		[Authorize]
		public async Task<IActionResult> AllExams()
		{
			var exams = await _examService.GetAllExams();
			return View(exams);
		}

		[Authorize]
		public async Task<IActionResult> GetExamTakeById(int examId)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (userId == null) return Unauthorized();

			var exam = await _examService.GetExamTakeById(examId, userId);

			if (exam == null) return NotFound();

			return View("ExamTakeView", exam);
		}

		[Authorize]
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SubmitExam(ExamSubmitDTO dto, int ExamScoredId)
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if(userId == null) return Unauthorized();

			try
			{
                var examScoredId = await _examService.SubmitExamAsync(dto, ExamScoredId);

				if(Request.Headers["X-Requested-With"] == "XMLHttpRequest")
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

		[HttpGet]
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
