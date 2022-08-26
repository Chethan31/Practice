using Microsoft.EntityFrameworkCore;
using SumOfTwoNumbers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers.Data
{
    public class DataBaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MathDb2022EF;Integrated Security=True");
        }

        DbSet<DataOfTwoNumbers> NumberData { get; set; }
    }
}
