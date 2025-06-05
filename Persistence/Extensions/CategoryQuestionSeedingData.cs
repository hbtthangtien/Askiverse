using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Extensions
{
    public static class CategoryQuestionSeedingData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Level>().HasData(
                new Level { Id = 1, DisplayName = "Easy", CreatedAt = DateTime.Now },
                new Level { Id = 2, DisplayName = "Medium", CreatedAt = DateTime.Now },
                new Level { Id = 3, DisplayName = "Hard", CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<QuestionType>().HasData(
                new QuestionType { Id = 1, Name = "Multiple Choice", CreatedAt = DateTime.Now },
                new QuestionType { Id = 2, Name = "Fill in the Blank", CreatedAt = DateTime.Now },
                new QuestionType { Id = 3, Name = "Matching", CreatedAt = DateTime.Now }
            );
        }
    }
}
