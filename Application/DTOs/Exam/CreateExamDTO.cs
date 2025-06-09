using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
    using System.ComponentModel.DataAnnotations;

    public class CreateExamDTO
    {
        [Required(ErrorMessage = "Tiêu đề là bắt buộc")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Source Text là bắt buộc")]
        public string SourceText { get; set; } = null!;

        public string? Description { get; set; }

        [Required(ErrorMessage = "Môn học là bắt buộc")]
        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn môn học")]
        public int SubjectId { get; set; }

        public string? PremiumUserId { get; set; }

        public bool IsPublic { get; set; }

        public int TotalQuestion { get; set; } // số lượng câu hỏi (10, 25, 50)

        [MinLength(1, ErrorMessage = "Phải chọn ít nhất một câu hỏi")]
        public List<int> SelectedQuestionIds { get; set; } = new List<int>();
    }

    public class SearchBankQuestionFilter
    {
        public int? QuestionTypeId { get; set; }
        public int? LevelId { get; set; }
        public bool? IsPublic { get; set; }
        public string? Keyword { get; set; }
    }


}
