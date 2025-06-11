using Application.Interface.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	public class ExamScoredController : Controller
	{
		private readonly IExamScoredService _examScoredSerivce;

		public ExamScoredController(IExamScoredService examScoredSerivce)
		{
			_examScoredSerivce = examScoredSerivce;
		}

		public async Task<IActionResult> ViewResult(int examScoredId, int examId)
		{
			var examResult = await _examScoredSerivce.ViewResultAsync(examScoredId);
			ViewData["examScoredId"] = examScoredId;
			ViewData["ExamId"] = examId;
			return View(examResult);
		}

		public async Task<IActionResult> ViewDetails(int examId, int examScoredId)
		{
			var examDetails = await _examScoredSerivce.ViewDetailsAsync(examScoredId, examId);
			return View(examDetails);
		}

		public async Task<IActionResult> AllExamScoredByUserIdByExamId(string userId, int examId)
		{
			var examScored = await _examScoredSerivce.GetAllExamScoredByUserIdByExamIdAsync(userId, examId);
			return View(examScored);
		}
	}
}
