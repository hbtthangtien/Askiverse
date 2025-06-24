using Application.Interface.IServices;
using Application.UnitOfWork;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FavouriteService : Service ,IFavouriteService
    {
        public FavouriteService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

		public async Task AddFavouriteAsync(int examId, string userId)
		{
			var favourite = new Favourite
			{
				ExamId = examId,
				UserId = userId
			};

			await _unitOfWork.Favorites.AddAsync(favourite);
			await _unitOfWork.CommitAsync();
			return;
		}

		public async Task RemoveFavouriteAsync(int examId, string userId)
		{
			var favourite = new Favourite
			{
				ExamId = examId,
				UserId = userId
			};
			_unitOfWork.Favorites.RemoveAsync(favourite);
			await _unitOfWork.CommitAsync();
			return;
		}
	}
}
