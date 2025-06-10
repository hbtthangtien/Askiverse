using Application.DTOs.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IServices
{
    public interface IExamService
    {
		public Task<List<ExamDTO>> GetAllExams();
		public Task<ExamTakeDTO?> GetExamTakeById(int examId);
		public Task<int> SubmitExamAsync(ExamSubmitDTO dto, string userId);
	}
}
