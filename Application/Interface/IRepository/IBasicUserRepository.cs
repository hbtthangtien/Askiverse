using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.IRepository
{
    public interface IBasicUserRepository : IRepository<BasicUser>
    {
        public UserManager<BasicUser> UserManager { get; }

        public SignInManager<BasicUser> SignInManager { get; }
    }
}
