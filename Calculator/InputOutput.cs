using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMathLibrary;
using SimpleMathDataLayer;

namespace Calculator
{
    internal class InputOutput
    {
        static double result;
        public static double input(double a, double b, char choice)
        {
            switch (choice) {
                case '+':
                    result=SimpleMath.Add(a, b);
                    break;
                case '-':
                    result = SimpleMath.Sub(a, b);
                    break;
                case '*':
                    result = SimpleMath.Mul(a, b);
                    break;
                case '/':
                    result = SimpleMath.Div(a, b);
                    break;
            }
            DbRepository.SaveData(a, b, result, choice);
            return result;
        }
    }
}
