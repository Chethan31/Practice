using System.Xml.Linq;

namespace LinqDemo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument xml = XDocument.Load(@"C:\Users\rchethan\source\repos\Practice\LinqDemo6\XMLFile1.xml");

            //querry 1
            Console.WriteLine("1.Display xml data:");
            Console.WriteLine(xml);
            Console.WriteLine();

            //querry 2
            Console.WriteLine("2.The name of all Employees:");
            var result = from emp in xml.Descendants("Employee")
                         select emp.Element("Name").Value;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //querry 3
            Console.WriteLine("3.The Employee name and ID of all the employees:");
            var result1 = from emp in xml.Descendants("Employee")
                          select new { empId = emp.Element("EmpId").Value, Name = emp.Element("Name").Value };
            foreach (var item in result1)
            {
                Console.WriteLine(item.empId + "," + item.Name);
            }
            Console.WriteLine();

            //querry 4
            Console.WriteLine("4.List the names of all female employees only:");
            var result2 = from emp in xml.Descendants("Employee")
                          where emp.Element("Sex").Value == "Female"
                          select new { empId = emp.Element("EmpId").Value, Name = emp.Element("Name").Value };
            foreach (var item in result2)
            {
                Console.WriteLine(item.empId + "," + item.Name);
            }
            Console.WriteLine();

            //querry 5
            Console.WriteLine("5.List of all the Home Phone numbers:");
            var result3 = from emp in xml.Descendants("Employee").Descendants("Phone")
                          where (string)emp.Attribute("Type") == "Home"
                          select emp.Value;
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //querry 6
            Console.WriteLine("6.List of all the employee names living in ‘Alta’ city:");
            var result4 = from emp in xml.Descendants("Employee")
                      where emp.Element("Address").Descendants("City").ElementAt(0).Value == "Alta"
                      select emp;

            foreach (var item in result4)
            {
                Console.WriteLine(item.Element("Name").Value);
            }
            Console.WriteLine();

            //querry 7
            Console.WriteLine("7.List and sort all the Zip codes:");
            var result5 = from emp in xml.Descendants("Employee")
                          orderby emp.Element("Address").Descendants("Zip").ElementAt(0).Value
                          select emp;

            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //querry 8
            Console.WriteLine("8.List the details of first 2 employees:");
            var result6 = from emp in xml.Descendants("Employee")
                          select emp;
            var firstResult = result6.First();
            var secondResult = result6.Skip(1).Take(1).Single();
            Console.WriteLine(firstResult);
            Console.WriteLine(secondResult);
            Console.WriteLine();

            //querry 9
            Console.WriteLine("9.Count the number of employees living in the state ‘CA’:");
            var result7 = from emp in xml.Descendants("Employee")
                          where emp.Element("Address").Descendants("State").ElementAt(0).Value == "CA"
                          group emp by emp.Element("Address").Descendants("State").ElementAt(0).Value into cat
                          select new {count = cat.Count()};
            foreach (var item in result7)
            {
                Console.WriteLine("Employees in CA : " + item.count);
            }
            Console.WriteLine();

            //querry 10
            Console.WriteLine("10.List all female employee names and city:");
            var result8 = from emp in xml.Descendants("Employee")
                          where emp.Element("Sex").Value == "Female"
                          select emp;

            foreach (var item in result8)
            {
                Console.WriteLine("Name:"+item.Element("Name").Value+", City:"+ item.Element("Address").Descendants("City").ElementAt(0).Value + ", Gender:"+item.Element("Sex").Value);
            }
            Console.WriteLine();
        }
    }
}

//result.Element("Category").Descendants("Cate1").ElementAt(0).Value 
//result.Element("Category").Descendants("Cate2").ElementAt(0).Value


