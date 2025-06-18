using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question
{
    public class CreateBankQuestionDTO
    {
        [Required]
        public string? Content { get; set; }
        [Required]
        public int QuestionTypeId { get; set; }
        public string? QuestionTypeName { get; set; } // ✅

        [Required]
        public int LevelId { get; set; }
        public string? LevelName { get; set; } // ✅

        public bool IsPublic { get; set; }

        public List<CreateAnswerDTO> Answers { get; set; } = new();
    }

    public class CreateAnswerDTO
    {
        public int Id { get; set; } = 0; // luôn = 0 khi tạo mới
        [Required]
        public string? AnswerText { get; set; }
        public bool IsCorrected { get; set; }
        public string? MatchingPairKey { get; set; }
        public bool IsDeleted { get; set; } = false;
    }


}
