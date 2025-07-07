using Application.DTOs.ExportDocx;
using Application.Interface.IExternalService;
using GrapeCity.Documents.Word;
using GemBox.Document;
using GBSaveOptions = GemBox.Document.SaveOptions;
using Microsoft.AspNetCore.Hosting;
namespace Infrastructure.ExternalService
{
    public class ExportFileDocxService : IExportFileDocxService
    {
        private readonly IWebHostEnvironment _env;
        public ExportFileDocxService(IWebHostEnvironment webHostEnvironment)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            _env = webHostEnvironment;
        }

        public byte[] Export(ExamTemplateDto exam)
        {
            string templatePath = Path.Combine(_env.WebRootPath, "templateDocx", "template_multiple_choice.docx");
            var document = DocumentModel.Load(templatePath);
            for (int i = 0; i < exam.Questions.Count; i++)
            {
                var q = exam.Questions[i];
                int n = i + 1;
                document.Content.Replace($"[ Question {n}]", q.Content);
                document.Content.Replace($"[A{n}]", q.A);
                document.Content.Replace($"[B{n}]", q.B);
                document.Content.Replace($"[C{n}]", q.C);
                document.Content.Replace($"[D{n}]", q.D);
            }

            using (var stream = new MemoryStream())
            {
                document.Save(stream, GBSaveOptions.DocxDefault);
                return stream.ToArray();
            }
        }

    }
}
