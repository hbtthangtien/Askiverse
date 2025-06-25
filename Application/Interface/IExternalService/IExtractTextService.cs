using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IExternalService
{
    public interface IExtractTextService
    {
        public IExtractTextFromImageService ExtractTextFromImageService { get; }

        public IExtractTextFilePdfService ExtractTextFilePdfService { get; }

        public IExtractextFileDocService ExtractextFileDocService { get; }

        public List<(string ChapterTitle, string ChapterText)> Extractext(IFormFile file);
    }
}
