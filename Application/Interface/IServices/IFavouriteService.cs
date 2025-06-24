using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IServices
{
    public interface IFavouriteService
    {
        public Task AddFavouriteAsync(int examId, string userId);
        public Task RemoveFavouriteAsync(int examId, string userId);
    }
}
