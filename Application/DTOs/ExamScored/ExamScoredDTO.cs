using Application.DTOs.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ExamScored
{
	public class ExamScoredDTO
	{
		public int Id {  get; set; }
		public DateTime StartTime { get; set; }

		public DateTime SubmitedTime { get; set; }

		public double Score { get; set; }

		public int ExamId { get; set; }

		public virtual ExamDTO? Exam { get; set; }
	}
}
