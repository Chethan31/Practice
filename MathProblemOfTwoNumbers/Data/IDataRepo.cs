using SumOfTwoNumbers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers.Data
{
    public interface IDataRepo
    {
        public void Save(DataOfTwoNumbers numbers);
        public DataOfTwoNumbers Read(int id);
    }
}
