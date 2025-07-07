using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ExportDocx
{
    public class ExamTemplateDto
    {
        public List<QuestionTemplateDto> Questions { get; set; }
    }
}
