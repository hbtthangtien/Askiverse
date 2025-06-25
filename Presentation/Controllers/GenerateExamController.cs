using Application.DTOs.Question.GenerateAI;
using Application.Interface.IExternalService;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class GenerateExamController : Controller
    {
        private IExtractextFileDocService _extractFile;
        private IExtractTextFilePdfService _extractTextPdf;
        private IExtractTextFromImageService _extractTextFromImageService;
        private IOpenAIService _openAiService;
        public GenerateExamController(IExtractextFileDocService extractFile,
            IExtractTextFilePdfService extractTextPdf,
            IExtractTextFromImageService extractTextFromImageService,
            IOpenAIService openAiService)
        {
            _extractFile = extractFile;
            _extractTextPdf = extractTextPdf;
            _extractTextFromImageService = extractTextFromImageService;
            _openAiService = openAiService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/documents")]
        public async Task<IActionResult> ExtractText([FromForm] RequestGenerateAI request)
        {
            var data = await _openAiService.GenerateExamByAI(request);
            return Ok(data);
        }
    }
}
