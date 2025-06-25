using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question.GenerateAI
{
    public class RequestGenerateAI
    {
        public IFormFile File {  get; set; }

        public int QuestionTypeId { get; set; }

        public int NumberEasyQuestion { get; set; }

        public int NumberMediumQuestion { get; set; }

        public int NumberHardQuestion { get; set; }
    }
}
