using Application.DTOs.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question
{
    public class QuestionViewDetailsDTO
    {
        public int Id { get; set; }
        public string? Content { get; set; } = default!;
        public List<AnswerDTO> Answers { get; set; } = new();
    }
}
