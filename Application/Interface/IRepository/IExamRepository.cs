using Application.DTOs.Exam;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IExamRepository : IRepository<Exam>
    {
		public Task<List<Exam>> GetAllExams();
		public Task<ExamTakeDTO?> GetExamTakeById(int examId, string userId);
        public Task<int> SubmitExamAsync(ExamSubmitDTO dto, int ExamScoredId);
	}
}
