using Application.DTOs.ExamAnswered;
using Application.DTOs.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
    public class ExamViewDetailsDTO
    {
        public int Id { get; set; }
        public int ExamScoredId { get; set; }
        public int ExamAnswererId { get; set; }
        public List<QuestionViewDetailsDTO> Questions { get; set; } = new();
        public List<ExamAnsweredDTO> UserAnswered { get; set; } = new();
    }
}
