using Application.DTOs.Question.GenerateAI;
using Application.Interface.IExternalService;
using Application.Interface.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Authorize]
    public class GenerateExamController : Controller
    {
        private readonly IOpenAIService _openAIService;
        private readonly IExamService _examService;
        public GenerateExamController(IOpenAIService openAIService,
                IExamService examService)
        {
            _openAIService = openAIService;
            _examService = examService;
        }
        public async Task<IActionResult> Index()
        {
            var subjects = await _examService.GetAllSubjectsAsync();
            var questionTypes = await _examService.GetAllQuestionTypesAsync();
            var levels = await _examService.GetAllLevelsAsync();
            ViewBag.Subjects = subjects;
            ViewBag.QuestionTypes = questionTypes;
            ViewBag.Levels = levels;
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
