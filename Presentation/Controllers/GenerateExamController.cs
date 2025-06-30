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
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Invalid model" });
            }

            try
            {
                var data = await _openAIService.GenerateExamByAI(request);
                if (data != null)
                {
                    // Return success with the generated data (you can pass additional info as well)
                    return Json(new { success = true, message = "Exam generated successfully!", data = data });
                }
                else
                {
                    return Json(new { success = false, message = "Error generating exam, please try again." });
                }
            }
            catch (Exception ex)
            {
                // Log the exception and return an error message
                // Log exception here (using your logging framework)
                return Json(new { success = false, message = $"An error occurred: {ex.Message}" });
            }
        }
    }
}
