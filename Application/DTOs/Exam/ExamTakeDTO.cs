using Application.DTOs.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
	public class ExamTakeDTO
	{
        public int Id { get; set; }
        public string? Title { get; set; }
        public TimeSpan TotalTime { get; set; }
        public List<QuestionTakeDTO> Questions { get; set; } = new();
        public int ExanScoredId { get; set; }
    }
}
