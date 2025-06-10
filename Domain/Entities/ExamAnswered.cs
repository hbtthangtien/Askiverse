using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ExamAnswered : BaseEntity
    {

        public int ExamScoredId { get; set; }

        public int  AnswerId { get; set; }

        public int QuestionExamId { get; set; }

        public bool IsCorrected { get; set; }

        public virtual ExamScored? ExamScored { get; set; }

        public virtual Answer? Answer {  get; set; } 

        public virtual QuestionExam? QuestionExam { get; set; }
    }
}
