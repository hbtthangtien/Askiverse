using Application.DTOs.ExportDocx;
using Application.Interface.IExternalService;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Hosting;
namespace Infrastructure.ExternalService
{
    public class ExportFileDocxService : IExportFileDocxService
    {
        private readonly IWebHostEnvironment _env;
        public ExportFileDocxService(IWebHostEnvironment webHostEnvironment)
        {
            _env = webHostEnvironment;
        }

        //public byte[] Export(ExamTemplateDto exam)
        //{
        //    string templatePath = Path.Combine(_env.WebRootPath, "templateDocx", "template_multiple_choice.docx");
        //    var document = DocumentModel.Load(templatePath);
        //    for (int i = 0; i < exam.Questions.Count; i++)
        //    {
        //        var q = exam.Questions[i];
        //        int n = i + 1;
        //        document.Content.Replace($"[ Question {n}]", q.Content);
        //        document.Content.Replace($"[A{n}]", q.Answers[0]);
        //        document.Content.Replace($"[B{n}]", q.Answers[1]);
        //        document.Content.Replace($"[C{n}]", q.Answers[2]);
        //        document.Content.Replace($"[D{n}]", q.Answers[3]);
        //    }

        //    using (var stream = new MemoryStream())
        //    {
        //        document.Save(stream, GBSaveOptions.DocxDefault);
        //        return stream.ToArray();
        //    }
        //}

        public byte[] Export(ExamTemplateDto exam)
        {
            using var stream = new MemoryStream();
            using (var wordDoc = WordprocessingDocument.Create(stream, WordprocessingDocumentType.Document, true))
            {
                var mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document();
                var body = new Body();

                if (exam.Questions != null && exam.Questions.Count > 0)
                {
                    for (int i = 0; i < exam.Questions.Count; i++)
                    {
                        var q = exam.Questions[i];
                        int n = i + 1;

                        body.Append(new Paragraph(new Run(new Text($"Câu {n}. {q.Content}"))));

                        if (q.Answers != null && q.Answers.Count >= 4)
                        {
                            body.Append(new Paragraph(new Run(new Text($"A. {q.Answers[0]}"))));
                            body.Append(new Paragraph(new Run(new Text($"B. {q.Answers[1]}"))));
                            body.Append(new Paragraph(new Run(new Text($"C. {q.Answers[2]}"))));
                            body.Append(new Paragraph(new Run(new Text($"D. {q.Answers[3]}"))));
                        }

                        body.Append(new Paragraph(new Run(new Text(""))));
                    }
                }
                else
                {
                    body.Append(new Paragraph(new Run(new Text("Không có câu hỏi nào."))));
                }

                mainPart.Document.Body = body;
                mainPart.Document.Save();
            }

            stream.Position = 0;
            return stream.ToArray();
        }
    }
}
