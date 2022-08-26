using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers.Entities
{
    public class DataOfTwoNumbers
    {
        public int Id { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public char Operator { get; set; }
        public double result { get; set; }

    }
}
