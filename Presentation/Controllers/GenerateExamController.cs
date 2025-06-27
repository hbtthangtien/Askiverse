using Application.DTOs.Question.GenerateAI;
using Application.Interface.IExternalService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Authorize]
    public class GenerateExamController : Controller
    {
        private readonly IOpenAIService _openAIService;
        public GenerateExamController(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }
        public IActionResult Index()
        {
            return View(new RequestGenerateAI { });
        }

        [HttpPost]
        public async Task<IActionResult> Index(RequestGenerateAI request)
        {
            var data = await _openAIService.GenerateExamByAI(request);
            return RedirectToAction("AllExams", "Exam");
        }
    }
}
