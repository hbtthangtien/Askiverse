﻿using Application.DTOs.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Question
{
	public class QuestionTakeDTO
	{
        public int Id { get; set; }
        public string? Content { get; set; } = default!;
		public int QuestionTypeId { get; set; }
		public List<AnswerDTO> Answers { get; set; } = new();
    }
    public class QuestionFlashcardDTO
    {
        public int Id { get; set; }
        public string? Content { get; set; } = default!;
        public int QuestionTypeId { get; set; }
        public List<AnswerDetailDTO> Answers { get; set; } = new();
    }
}
