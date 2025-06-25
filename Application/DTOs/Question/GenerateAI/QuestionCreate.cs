using Application.DTOs.Question.GenerateAI.AnswerAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question.GenerateAI
{
    public class QuestionCreate
    {
        public int QuestionTypeId { get; set; }

        public int LevelId { get; set; }

        public bool IsPublic { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? Content { get; set; }

        public List<AnswerCreate> Answers { get; set; } = new List<AnswerCreate>();
    }
}
