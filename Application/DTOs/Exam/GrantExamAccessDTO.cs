using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
    public class GrantExamAccessDTO
    {
        public string Email { get; set; } = null!;
        public int ExamId { get; set; }
        public bool Permission { get; set; } 
    }


}
