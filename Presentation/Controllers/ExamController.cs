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
			if(userId == null) return Unauthorized();

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
