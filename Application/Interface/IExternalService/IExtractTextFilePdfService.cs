using Application.DTOs.Chapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IExternalService
{
    public interface IExtractTextFilePdfService
    {
        public List<ChapterDTO> ExtractChapters(Stream pdfStream);

        public long CountPagesPdfItext7(Stream pdfStream);
    }
}
