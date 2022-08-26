using MathProblemOfTwoNumbers.Data;
using SumOfTwoNumbers.Data;
using SumOfTwoNumbers.Entities;

namespace SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadData();
        }
        static void ReadData()
        {
            DataOfTwoNumbers data = new DataOfTwoNumbers();
            Console.WriteLine("Enter First Number:");
            data.FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            data.SecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation:");
            data.Operator = char.Parse(Console.ReadLine());
            Validate.valid(data);
        }   
    }
}