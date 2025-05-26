using Application.Interface.IRepository;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        private readonly AskiverseContext _context;

        public ProfileRepository(AskiverseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Profile?> GetByUserIdAsync(string userId)
        {
            return await _context.Profiles
                .Include(p => p.User)
                .FirstOrDefaultAsync(p => p.UserId == userId);
        }
        

        public void Update(Profile profile)
        {
            _context.Profiles.Update(profile);
        }
    }
}
