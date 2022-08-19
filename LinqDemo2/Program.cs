namespace LinqDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = GetEvenNumbers(numbers);

            numbers.Add(10);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<int> GetEvenNumbers(List<int> numbers)
        {
            var evens = (from n in numbers
                         where IsEven(n)
                         select n).ToList();
            return evens;
        }

        static bool IsEven(int n)
        {
            Console.WriteLine("In IsEven Method");
            return n % 2 == 0;
        }
    }
}