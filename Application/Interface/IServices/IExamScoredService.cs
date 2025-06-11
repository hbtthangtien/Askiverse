using Application.DTOs.Exam;
using Application.DTOs.ExamScored;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IServices
{
    public interface IExamScoredService
    {
        public Task<ExamScoredDTO?> ViewResultAsync(int examId);
        public Task<ExamViewDetailsDTO?> ViewDetailsAsync(int examScoredId, int examId);
	}
}
