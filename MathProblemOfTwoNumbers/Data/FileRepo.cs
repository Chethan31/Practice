using SumOfTwoNumbers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers.Data
{
    public class FileRepo : IDataRepo
    {
        public DataOfTwoNumbers Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(DataOfTwoNumbers numbers)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter("D:/Data.txt", true);
                writer.WriteLine(numbers.FirstNumber + " " + numbers.Operator + " " + numbers.SecondNumber + " = " + numbers.result);
            }
            finally
            {
                writer.Close();
            }
        }
    }
}
