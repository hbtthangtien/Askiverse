using Application.DTOs.Chapters;
using Application.Interface.IExternalService;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System.Text;
using System.Text.RegularExpressions;

namespace Infrastructure.ExternalService
{
    public class ExtractTextFilePdfService : IExtractTextFilePdfService
    {
        public List<ChapterDTO> ExtractChapters(Stream pdfStream)
        {
            var sb = new StringBuilder();
            using (var pdfDoc = new PdfDocument(new PdfReader(pdfStream)))
            {
                int numPages = pdfDoc.GetNumberOfPages();
                for (int i = 1; i <= numPages; i++)
                {
                    var page = pdfDoc.GetPage(i);
                    var text = PdfTextExtractor.GetTextFromPage(page);
                    sb.AppendLine(text);
                }
            }

            string pdfText = sb.ToString();
            var regex = new Regex(@"(Chương\s+\w+|Chapter\s+\w+|PHẦN\s+\w+|MỤC\s+\w+)[\.:]?\s*(.*)?", RegexOptions.IgnoreCase);
            var matches = regex.Matches(pdfText);
            var chapters = new List<ChapterDTO>();
            int lastIndex = 0;

            for (int i = 0; i < matches.Count; i++)
            {
                int startIdx = matches[i].Index;
                string title = matches[i].Value;

                int endIdx = (i + 1 < matches.Count) ? matches[i + 1].Index : pdfText.Length;
                string content = pdfText.Substring(startIdx + title.Length, endIdx - (startIdx + title.Length));

                chapters.Add(new ChapterDTO
                {
                    Title = title,
                    Content = content
                });
            }

            // Nếu không tìm được chương nào, trả về toàn bộ text (1 phần)
            if (chapters.Count == 0)
            {
                chapters.Add(new ChapterDTO { Title = "Toàn bộ tài liệu", Content = pdfText });
            }

            return chapters;
        }
    
    }
}
