using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Models
{
    public class StudentContext: DbContext
    {
        public DbSet<Stud> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=StudDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}

