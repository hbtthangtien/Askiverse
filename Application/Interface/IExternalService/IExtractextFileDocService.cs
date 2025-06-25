using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IExternalService
{
    public interface IExtractextFileDocService
    {
        public List<(string ChapterTitle, string ChapterText)> ExtractChapters(Stream stream);

        public long CountWordDocx(Stream stream);
    }
}
