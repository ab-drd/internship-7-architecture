using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using POS.Data.Entities.Models;

namespace POS.Data.Seeds
{
    public static class DataBaseSeed
    {
        public static void Seed(ModelBuilder builder) 
        {
            builder.Entity<Employee>()
                .HasData(new List<Employee>
                {
                    new Employee
                    {
                        Id = 1,
                        FirstName = "Ante",
                        LastName = "Antic",
                        WorktimeStart = new DateTime(2010, 01, 01, 7, 0, 0),
                        WorktimeEnd = new DateTime(2010, 01, 01, 16, 0, 0)
                    }
                });

            builder.Entity<Article>()
                .HasData(new List<Article>
                {
                    new Article
                    {
                    }
                });
        }
    }
}
