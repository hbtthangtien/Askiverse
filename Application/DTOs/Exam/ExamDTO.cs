﻿using Application.DTOs.ExamScored;
using Application.DTOs.Favourite;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Exam
{
	public class ExamDTO
	{
		// cho phan hien thi danh sach cac de thi
		
		public int Id { get; set; }

		public string? Title { get; set; }

		public string? Description { get; set; }

		public string? SourceText { get; set; }

		public int TotalQuestion { get; set; }

		public DateTime CreatedAt { get; set; }

		public bool IsPublic { get; set; }
       
        public bool CanEdit { get; set; } // Có quyền sửa (người tạo hoặc được cấp quyền)
        public bool HasBeenScored { get; set; } // Đã được làm chưa
        public virtual PremiumUser? PremiumUser { get; set; }

        public virtual Domain.Entities.Subject? Subject { get; set; }

        public virtual ICollection<ExamScoredDTO> ExamScoreds { get; set; } = new List<ExamScoredDTO>();

		public virtual ICollection<FavouriteDTO> FavouritedByUsers { get; set; } = new List<FavouriteDTO>();
	}
}
