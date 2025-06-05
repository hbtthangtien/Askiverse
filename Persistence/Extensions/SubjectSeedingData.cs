using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Extensions
{
    public static class SubjectSeedingData
    {
        public static void Seeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>(entity =>
            {
                List<Subject> subjects = new List<Subject>
                {
                    new Subject { Id = 1, Name = "Toán học", CreatedAt = DateTime.Now },
                    new Subject { Id = 2, Name = "Ngữ văn", CreatedAt = DateTime.Now },
                    new Subject { Id = 3, Name = "Tiếng Anh", CreatedAt = DateTime.Now },
                    new Subject { Id = 4, Name = "Vật lý", CreatedAt = DateTime.Now },
                    new Subject { Id = 5, Name = "Hóa học", CreatedAt = DateTime.Now },
                    new Subject { Id = 6, Name = "Sinh học", CreatedAt = DateTime.Now },
                    new Subject { Id = 7, Name = "Lịch sử", CreatedAt = DateTime.Now },
                    new Subject { Id = 8, Name = "Địa lý", CreatedAt = DateTime.Now },
                    new Subject { Id = 9, Name = "Giáo dục công dân", CreatedAt = DateTime.Now },
                    new Subject { Id = 10, Name = "Tin học", CreatedAt = DateTime.Now },
                    new Subject { Id = 11, Name = "Công nghệ", CreatedAt = DateTime.Now },
                    new Subject { Id = 12, Name = "Thể dục", CreatedAt = DateTime.Now }
                };
                entity.HasData(subjects);
            });
        }
    }
}
