using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
    public class EditExamDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống.")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Mô tả không được để trống.")]
        public string SourceText { get; set; } = null!;

        public string? Description { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn môn học.")]
        public int SubjectId { get; set; }

        public bool IsPublic { get; set; }

        public int TotalQuestion { get; set; }

        public List<int> SelectedQuestionIds { get; set; } = new();
    }

}
