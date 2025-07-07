using Application.DTOs.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question.GenerateAI
{
    public class SaveExamDTO
    {
        public CreateExamDTO ExamData { get; set; }

        public List<QuestionCreate> Questions { get; set; }

    }
}
