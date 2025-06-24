using Application.Interface.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	public class FavouriteController : Controller
	{
		private readonly IFavouriteService _favouriteService;

		public FavouriteController(IFavouriteService favouriteService)
		{
			_favouriteService = favouriteService;
		}

		public async Task AddFavourite(int examId, string userId)
		{
			try
			{
				await _favouriteService.AddFavouriteAsync(examId, userId);
			}
			catch (Exception ex)
			{
				ViewData["ErrorFavourite"] = ex.Message;
			}
		}

		public async Task RemoveFavourite(int examId, string userId)
		{
			try
			{
				await _favouriteService.RemoveFavouriteAsync(examId, userId);
			}
			catch (Exception ex)
			{
				ViewData["ErrorFavourite"] = ex.Message;
			}
		}
	}
}
