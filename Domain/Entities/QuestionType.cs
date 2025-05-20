using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class QuestionType : BaseEntity
    {

        public string Name { get; set; }

        public ICollection<BankQuestion> BankQuestions { get; set; } = new List<BankQuestion>();
    }
}
