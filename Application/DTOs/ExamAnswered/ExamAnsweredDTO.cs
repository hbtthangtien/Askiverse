﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ExamAnswered
{
    public class ExamAnsweredDTO
    {
        public int AnswerId { get; set; } = new();
        public int QuestionId { get; set; } = new();
    }
}
