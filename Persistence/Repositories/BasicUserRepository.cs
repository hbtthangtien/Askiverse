using Application.Interface.IRepository;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class BasicUserRepository : Repository<BasicUser>, IBasicUserRepository
    {
        public UserManager<BasicUser> UserManager { get; private set; }

        public SignInManager<BasicUser> SignInManager { get;private set; }
        public BasicUserRepository(AskiverseContext context,
            UserManager<BasicUser> userManager,
            SignInManager<BasicUser> signInManager) : base(context)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        public async Task<BasicUser?> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }


    }
}
