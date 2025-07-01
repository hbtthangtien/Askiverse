using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
    public class QuestionDetailDTO
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public int QuestionTypeId { get; set; }         
        public string? QuestionTypeName { get; set; }
        public List<AnswerDTO> Answers { get; set; } = new();
    }

    public class AnswerDTO
    {
        public int Id { get; set; }
        public string? AnswerText { get; set; }
        public bool IsCorrected { get; set; }
        public string? MatchingPairKey { get; set; }
    }

}
