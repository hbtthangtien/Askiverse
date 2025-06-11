using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Answer
{
	public class AnswerDTO
	{
        public int Id { get; set; }
        public string? AnswerText { get; set; } = default!;
        public bool IsCorrected { get; set; }
    }
}
