using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Extensions
{
    public static class SubscriptionSeedingData
    {
        public static void Seeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubcriptionPackages>(entity =>
            {
                List<SubcriptionPackages> packages = new List<SubcriptionPackages>
                {
                    new SubcriptionPackages
                    {
                        Id = 1,
                        Name = "Gói cơ bản",
                        Description = "Truy cập nội dung cơ bản",
                        Price = 99000,
                        Duration = Duration.HalfAMonths,
                        CreatedAt = DateTime.Now
                    },
                    new SubcriptionPackages
                    {
                        Id = 2,
                        Name = "Gói nâng cao",
                        Description = "Truy cập toàn bộ nội dung và hỗ trợ ưu tiên",
                        Price = 199000,
                        Duration = Duration.AMonths,
                        CreatedAt = DateTime.Now
                    },
                    new SubcriptionPackages
                    {
                        Id = 3,
                        Name = "Gói hàng năm",
                        Description = "Truy cập không giới hạn trong 1 năm",
                        Price = 1990000,
                        Duration = Duration.Annual,
                        CreatedAt = DateTime.Now
                    }
                };
                entity.HasData(packages);
            });
        }
    }
}
