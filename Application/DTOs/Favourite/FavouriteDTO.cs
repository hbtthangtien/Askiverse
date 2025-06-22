using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Favourite
{
	public class FavouriteDTO
	{
		public string UserId { get; set; } = null!;
		public int ExamId { get; set; }
	}
}
