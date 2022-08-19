using System.Xml.Linq;

namespace LinqDemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "one", "two", "three", "four", "five", "six" };
            var shortWords = from w in words
                             where w.Length <= 3
                             select w;

            //foreach (var item in shortWords)
            //{
            //    Console.WriteLine(item);
            //}

            XDocument xml = XDocument.Load("XMLFile1.xml");

            var shortWords1 = from w in xml.Descendants("word")
                              where w.Value.Length <= 3
                              orderby w.Value descending
                              select w.Value;

            var shortWords2 = xml.Descendants("word")
                .Where(w => w.Value.Length <= 3)
                .OrderByDescending(w => w.Value);






            foreach (var item in shortWords1)
            {
                Console.WriteLine(item);
            }

        }
    }
}