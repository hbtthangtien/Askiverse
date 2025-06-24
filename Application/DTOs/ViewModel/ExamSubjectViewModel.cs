using Application.DTOs.Exam;
using Application.DTOs.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ViewModel
{
    public class ExamSubjectViewModel
    {
        public List<ExamDTO> Exams { get; set; }
        public List<SubjectDTO> Subjects { get; set; }
    }
}