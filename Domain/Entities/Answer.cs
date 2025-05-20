using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Answer : BaseEntity
    {

        public int BankQuestionId { get; set; }

        public string? AnswerText { get; set; }

        public bool IsCorrected { get; set; }

        public string? MatchingPairKey { get; set; }

        public virtual BankQuestion? BankQuestion { get; set; }


    }
}
