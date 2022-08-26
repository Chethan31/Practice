using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers.Data
{
    public class Addition : IMaths
    {
        public double result(int a, int b)
        {
            return a + b;
            
        }
    }
}
