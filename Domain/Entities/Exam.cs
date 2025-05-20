using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Exam : BaseEntity
    {

        public string? PremiumUserId { get; set; }

        public int? SubjectId { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public required string SourceText { get; set; }

        public int TotalQuestion { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsPublic { get; set; }

        public virtual PremiumUser? PremiumUser {  get; set; }
        
        public virtual Subject? Subject { get; set; }

        public virtual ICollection<ExamAccess> ExamAccesses { get; set; } =  new List<ExamAccess>();

        public virtual ICollection<QuestionExam> QuestionExam { get; set; } = new List<QuestionExam>();

        public virtual ICollection<ExamScored> ExamScoreds { get; set; } = new List<ExamScored>();


    }
}
