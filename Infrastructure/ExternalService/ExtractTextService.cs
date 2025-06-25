using Application.Interface.IExternalService;
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
    }
}
