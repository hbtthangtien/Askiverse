using Application.DTOs.Exam;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ExamService : Service, IExamService
    {
        public ExamService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<List<ExamDTO>> GetAllExams()
        {
            var exams = await _unitOfWork.Exams.GetAllAsync();
            return _mapper.Map<List<ExamDTO>>(exams);
        }

        public async Task<ExamTakeDTO?> GetExamTakeById(int examId)
        {
            var exam = await _unitOfWork.Exams.GetExamTakeById(examId);
            return exam;
        }

        public async Task<int> SubmitExamAsync(ExamSubmitDTO dto, string userId)
        {
            var examScoredId = await _unitOfWork.Exams.SubmitExamAsync(dto, userId);
            return examScoredId;
        }

	}
}
