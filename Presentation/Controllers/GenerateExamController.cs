using Application.Interface.IExternalService;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class GenerateExamController : Controller
    {
        private IExtractextFileDocService _extractFile;
        private IExtractTextFilePdfService _extractTextPdf;
        private IExtractTextFromImageService _extractTextFromImageService;
        public GenerateExamController(IExtractextFileDocService extractFile,
            IExtractTextFilePdfService extractTextPdf,
            IExtractTextFromImageService extractTextFromImageService)
        {
            _extractFile = extractFile;
            _extractTextPdf = extractTextPdf;
            _extractTextFromImageService = extractTextFromImageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("api/documents")]
        public async Task<IActionResult> ExtractText(IFormFile formFile)
        {
            var stream = formFile.OpenReadStream();
            var data = _extractTextFromImageService.ExtractChapters(stream);
            return Ok(data);
        }
    }
}
