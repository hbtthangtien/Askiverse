using Application.Interface.IExternalService;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infrastructure.ExternalService
{
    public class ExtractTextFromDocxService : IExtractextFileDocService
    {
        /// <summary>
        /// Tách nội dung word thành các chương/mục dựa vào heading hoặc tiêu đề thường (bằng regex).
        /// </summary>
        /// <param name="stream">Stream file Word</param>
        /// <returns>List các chương: tiêu đề + nội dung</returns>
        public List<(string ChapterTitle, string ChapterText)> ExtractChapters(Stream stream)
        {
            var doc = new XWPFDocument(stream);
            var chapters = new List<(string ChapterTitle, string ChapterText)>();
            string currentTitle = null;
            var regexTitle = new Regex(@"^(Chương\s+\w+|Chapter\s+\w+|PHẦN\s+\w+|MỤC\s+\w+)[\.:]?\s*(.*)?$", RegexOptions.IgnoreCase);
            StringBuilder currentContent = new StringBuilder();

            foreach (var para in doc.Paragraphs)
            {
                var paraText = para.ParagraphText.Trim();

                bool isHeading = false;

                // Kiểm tra heading chuẩn (Heading1, Heading2)
                var style = para.Style;
                if (style != null && (style.Equals("Heading1", StringComparison.OrdinalIgnoreCase) ||
                                      style.Equals("Heading 1", StringComparison.OrdinalIgnoreCase)))
                {
                    isHeading = true;
                }
                // Nếu không phải heading chuẩn, kiểm tra bằng regex
                else if (regexTitle.IsMatch(paraText))
                {
                    isHeading = true;
                }

                if (isHeading)
                {
                    // Nếu đã có chương, lưu lại
                    if (currentTitle != null)
                    {
                        chapters.Add((currentTitle, currentContent.ToString().Trim()));
                    }
                    currentTitle = paraText;
                    currentContent.Clear();
                }
                else if (!string.IsNullOrWhiteSpace(paraText))
                {
                    // Gom nội dung cho chương hiện tại
                    currentContent.AppendLine(paraText);
                }
            }

            // Thêm chương cuối
            if (currentTitle != null)
            {
                chapters.Add((currentTitle, currentContent.ToString().Trim()));
                currentContent.Clear();
            }
                
            // nếu tài liệu không có tiêu đề
            if(currentTitle == null && currentContent.Length != 0)
            {
                chapters.Add(("Toàn bộ file docx", currentContent.ToString().Trim()));
            }
            return chapters;
        }

        /// <summary>
        /// Nếu muốn chia chunk theo số ký tự (ví dụ: tối đa 2500 ký tự / chunk)
        /// </summary>
        public List<string> ChunkText(string text, int maxLength = 2500)
        {
            List<string> chunks = new List<string>();
            for (int i = 0; i < text.Length; i += maxLength)
            {
                chunks.Add(text.Substring(i, Math.Min(maxLength, text.Length - i)));
            }
            return chunks;
        }

        public long CountWordDocx(Stream stream)
        {
            XWPFDocument doc = new XWPFDocument(stream);
            var sb = new StringBuilder();
            foreach (var para in doc.Paragraphs)
            {
                sb.AppendLine(para.ParagraphText);
            }
            var text = sb.ToString();
            // Đếm số từ
            var words = text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
