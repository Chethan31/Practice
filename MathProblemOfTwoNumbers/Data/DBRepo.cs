using Microsoft.EntityFrameworkCore;
using SumOfTwoNumbers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers.Data
{
    public class DBRepo : IDataRepo
    {
        
        public DataOfTwoNumbers Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(DataOfTwoNumbers numbers)
        {
            DataBaseContext db = new DataBaseContext();
            db.Add(numbers);
            db.SaveChanges();
        }
    }
}
