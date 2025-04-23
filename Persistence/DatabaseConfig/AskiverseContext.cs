using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DatabaseConfig
{
    public class AskiverseContext : IdentityDbContext<BasicUser>
    {
        public AskiverseContext(DbContextOptions<AskiverseContext> options) : base(options)
        {
        }
    }
}
