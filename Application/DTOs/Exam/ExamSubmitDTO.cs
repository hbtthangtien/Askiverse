using Application.DTOs.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
	public class ExamSubmitDTO
	{
		public int ExamId { get; set; }
		public List<AnswerSubmitDTO> Answers { get; set; } = new();
	}
}
