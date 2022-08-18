using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Validate
    {
        public static string Val(string a)
        {
            int number;
            if (a.Length != 10)
                throw new InvalidMobileNumberException("Enter 10 digit Mobile Number.");
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]) == false)
                    throw new InvalidMobileNumberException("Enter only Digit.");
            }
            if (a[0]!= '9')
                throw new InvalidMobileNumberException("Number should Start with 9.");

            return a;
        }
    }
}
