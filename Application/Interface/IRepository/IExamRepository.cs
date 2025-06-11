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
        public Task<ExamTakeDTO?> GetExamTakeById(int examId);
        public Task<int> SubmitExamAsync(ExamSubmitDTO dto, string userId);
	}
}
