using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question.GenerateAI
{
    public class RequestGenerateAI
    {
        [Required(ErrorMessage = "Vui lòng chọn file tài liệu.")]
        public IFormFile File { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại câu hỏi.")]
        public int QuestionTypeId { get; set; }

        public int NumberEasyQuestion { get; set; }

        public int NumberMediumQuestion { get; set; }

        public int NumberHardQuestion { get; set; }

        [Required]
        public int TotalQuestions { get; set; }
    }
}
