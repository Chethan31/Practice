namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // select all even numbers into separate collection and display

            // table: numbers
            // column: number

            // SQL Query: select number from numbers where number mod 2 = 0;
            // LINQ Query

            var result = (from en in numbers
                          where en % 2 == 0
                          select en).ToList();

            var result1 = numbers.Where(n => n % 2 == 0);


            List<int> evens = new List<int>();
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                    evens.Add(n);
            }

            foreach (var item in evens)
            {
                Console.WriteLine(item);
            }
        }
    }
}