using SumOfTwoNumbers.Data;
using SumOfTwoNumbers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemOfTwoNumbers.Data
{
    public class Validate
    {
        public static void valid(DataOfTwoNumbers data)
        {
            IMaths maths = null;
            IDataRepo file = new FileRepo();
            IDataRepo database = new DBRepo();
            double res;
            switch (data.Operator)
            {
                case '+':
                    maths = new Addition();
                    data.result = maths.result(data.FirstNumber, data.SecondNumber);
                    Console.WriteLine("The Sum of two Numbers:" + data.result);
                    file.Save(data);
                    database.Save(data);
                    break;
                case '-':
                    maths = new Subtraction();
                    data.result = maths.result(data.FirstNumber, data.SecondNumber);
                    Console.WriteLine("The Sub of two Numbers:" + data.result);
                    file.Save(data);
                    database.Save(data);
                    break;
                default:
                    break;
            }
        }
    }
}
