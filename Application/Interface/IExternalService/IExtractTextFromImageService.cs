using Application.DTOs.Chapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IExternalService
{
    public interface IExtractTextFromImageService
    {
        public List<ChapterDTO> ExtractChapters(Stream imageStream);
    }
}
