using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Answer
{
	public class AnswerSubmitDTO
	{
		public int QuestionId { get; set; }
		public int AnswerId { get; set; }
		public string? UserInput { get; set; }
		public List<MatchingPairDTO>? MatchingPairs { get; set; }

		// Dành cho binding từ input ẩn JSON (string → List)
		public string? MatchingPairsJson { get; set; }
	}

	public class MatchingPairDTO
	{
		public int AnswerId { get; set; }
		public string MatchingBlankKey { get; set; } = null!;
	}
}
