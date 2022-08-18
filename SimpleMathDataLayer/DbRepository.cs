using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathDataLayer
{
    public class DbRepository
    {
        public static void SaveData(double input1, double input2, double result, char choice)
        {
            StreamWriter writer = new StreamWriter("D://abc.txt", true);
            writer.WriteLine($"{input1} {choice} {input2} = {result}");
            writer.Close();
        }
    }
}
