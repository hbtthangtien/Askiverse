using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question.GenerateAI.AnswerAI
{
    public class AnswerCreate
    {
        public string? AnswerText { get; set; }

        public bool IsCorrected { get; set; }

        public string? MatchingPairKey { get; set; }
    }
}
