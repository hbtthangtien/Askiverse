using Application.DTOs.Exam;
using Application.DTOs.ExamScored;
using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ExamScoredService : Service, IExamScoredService
    {
        public ExamScoredService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

		public async Task<ExamScoredDTO?> ViewResultAsync(int examId)
        {
            var examResult = await _unitOfWork.ExamScoreds.GetExamScoredById(examId);
            return _mapper.Map<ExamScoredDTO>(examResult);
        }

        public async Task<ExamViewDetailsDTO?> ViewDetailsAsync(int examScoredId, int examId)
        {
            var examDetails = await _unitOfWork.ExamScoreds.GetExamDetails(examScoredId, examId);
            return examDetails;
        }
    }
}
