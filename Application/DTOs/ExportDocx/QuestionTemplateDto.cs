using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ExportDocx
{
    public class QuestionTemplateDto
    {
        public string Content { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
    }
}
