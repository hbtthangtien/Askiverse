using Application.Interface.IExternalService;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ExternalService
{
    public class ExtractTextService : IExtractTextService
    {
        public IExtractTextFromImageService ExtractTextFromImageService { get; private set; }

        public IExtractTextFilePdfService ExtractTextFilePdfService { get; private set; }

        public IExtractextFileDocService ExtractextFileDocService { get; private set; }

        public ExtractTextService(IExtractTextFromImageService extractTextFromImageService,
            IExtractTextFilePdfService extractTextFilePdfService,
            IExtractextFileDocService extractextFileDocService)
        {
            ExtractTextFromImageService = extractTextFromImageService;
            ExtractTextFilePdfService = extractTextFilePdfService;
            ExtractextFileDocService = extractextFileDocService;
        }

        public List<(string ChapterTitle, string ChapterText)> Extractext(IFormFile file)
        {
            var filename = file.FileName.ToLower();
            var stream = file.OpenReadStream();
            if (filename.Contains(".pdf"))
            {
                var chapters = ExtractTextFilePdfService.ExtractChapters(stream);
                var dtos = new List<(string ChapterTitle, string ChapterText)>();
                foreach(var chapter in chapters)
                {
                    dtos.Add((chapter.Title, chapter.Content));
                }
                return dtos;
            }
            else if (filename.Contains(".docx"))
            {
                var textExtract = ExtractextFileDocService.ExtractChapters(stream);
                return textExtract;
            }
            else
            {
                var chapters = ExtractTextFromImageService.ExtractChapters(stream);
                var dtos = new List<(string ChapterTitle, string ChapterText)>();
                foreach (var chapter in chapters)
                {
                    dtos.Add((chapter.Title, chapter.Content));
                }
                return dtos;
            }
        }
    }
}
