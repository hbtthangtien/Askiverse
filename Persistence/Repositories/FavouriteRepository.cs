using Domain.Entities;
using Persistence.DatabaseConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface.IRepository;

namespace Persistence.Repositories
{
    public class FavouriteRepository : Repository<Favourite>, IFavouriteRepository
    {
        public FavouriteRepository(AskiverseContext context) : base(context)
        {
        }
    }
}
