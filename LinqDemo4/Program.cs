using System.Xml.Linq;

namespace LinqDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new { FrameworkName = "first", SecondName = "second" };


            XDocument xml = XDocument.Load("XMLFile1.xml");

            var computerBooks = from b in xml.Descendants("book")
                                where b.Element("genre").Value == "Computer"
                                select new { Title = b.Element("title").Value, Author = b.Element("author").Value, Price = double.Parse(b.Element("price").Value) };

            foreach (var item in computerBooks)
            {
                Console.WriteLine(item);
            }
        }
    }

    class BookAuthorTitle
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    //class BookAuthorTitlePrice
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }

    //    public double Price { get; set; }
    //}
}