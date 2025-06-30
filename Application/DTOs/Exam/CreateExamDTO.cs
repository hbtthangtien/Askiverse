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
        [Required(ErrorMessage = "Tiêu đề không được để trống.")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Mô tả không được để trống.")]
        public string SourceText { get; set; } = null!;
        [Required(ErrorMessage = "Source Text không được để trống.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn môn học.")]
        public int SubjectId { get; set; }

        public string? PremiumUserId { get; set; }

        public bool IsPublic { get; set; }
        public int TotalTime { get; set; }
        public int TotalQuestion { get; set; } // số lượng câu hỏi (10, 25, 50)

        [Required(ErrorMessage = "Bạn phải chọn số lượng câu hỏi phù hợp.")]
        public List<int> SelectedQuestionIds { get; set; } = new List<int>();
    }

    public class SearchBankQuestionFilter
    {
        public int? QuestionTypeId { get; set; }
        public int? LevelId { get; set; }
        public bool? IsPublic { get; set; }
        public string? Keyword { get; set; }

        // Thêm thuộc tính phân trang
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }



}
