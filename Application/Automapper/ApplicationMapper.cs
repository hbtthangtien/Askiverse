using Application.DTOs.Exam;
using Application.DTOs.ExamScored;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Automapper
{
    public class ApplicationMapper : AutoMapper.Profile
    {
        public ApplicationMapper()
        {
            CreateMap<ExamDTO, Exam>().ReverseMap();
            CreateMap<ExamScoredDTO, ExamScored>().ReverseMap();
        }
    }
}