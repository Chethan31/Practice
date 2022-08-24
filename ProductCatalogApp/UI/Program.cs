using Microsoft.EntityFrameworkCore;
using ProductCatalogApp.Data;
using ProductCatalogApp.Entities;

namespace ProductCatalogApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Catagory c = new Catagory { CatagoryName="Laptop"};
            //Product p = new Product { ProductName="Hp 151",Price=10000,Brand="HP",Catagory=c};
            //ProductDbContext db = new ProductDbContext();
            //db.Products.Add(p);
            ////db.Catagories.Add(c);
            //db.SaveChanges();
            // CreateCatagory();
            // CreateProduct();
            //ProductDbContext db = new ProductDbContext();
            //var Delete = db.Products.Find(1);
            //db.Products.Remove(Delete);
            //db.SaveChanges();

            //newcustomer();

            //DisplayCustomer();




            int choice = 0;
            while (choice != 5)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Create Product");
                Console.WriteLine("2.Create Catagory");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.New(one catagory and two Product)");
                Console.Write("Enter Your Choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateProduct();
                        break;
                    case 2:
                        CreateCatagory();
                        break;
                    case 3:
                        Display();
                        break;
                    case 4:
                        new1();
                        break;
                    default:
                        break;
                }
            }
        }


        private static void newcustomer()
        {
            Customer c = new Customer { PersonName = "Sarvesh", CustomerType = "Silver", Discount = 10 };
            Supplier s = new Supplier { PersonName = "Rahul", GST = "412412", Rank = 1 };
            ProductDbContext db = new ProductDbContext();
            db.Suppliers.Add(s);
            db.Customers.Add(c);
            db.SaveChanges();
        }
        private static void DisplayCustomer()
        {
            ProductDbContext db = new ProductDbContext();
            var cus = from c in db.Customers
                              select c;
            Console.WriteLine("Product\tCatagory");
            foreach (var s in cus)
            {
                Console.WriteLine($"{s.PersonName}");
            }
        }
        private static void new1 ()//Add one new catagory with two new products
        {
            Catagory c = new Catagory { CatagoryName="Smart Watch"};
            Product p1 = new Product { ProductName = "IWatch", Price = 2000,Brand = "Apple"};
            Product p2 = new Product { ProductName = "Galaxy", Price = 4000, Brand = "Samsung" };
            c.Products.Add(p1);
            c.Products.Add(p2);
            ProductDbContext db = new ProductDbContext();   
            db.Catagories.Add(c);
            //db.Products.Add(p1);
            //db.Products.Add(p2);
            db.SaveChanges();
        }
        private static void Display()
        {
            ProductDbContext db = new ProductDbContext();
            var allProducts = from p in db.Products.Include("Catagory")
                              select p;
            Console.WriteLine("Product\tCatagory");
            foreach(var p in allProducts)
            {
                Console.WriteLine($"{p.ProductName}\t{p.Catagory.CatagoryName}");
            }
        }
        private static void CreateProduct()
        {
            Console.WriteLine("Product Details:");
            ProductDbContext db = new ProductDbContext();
            Product p = new Product();
            Console.Write("Enter Product Name:");
            p.ProductName = Console.ReadLine();
            Console.Write("Enter Product Price:");
            p.Price = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Brand:");
            p.Brand = Console.ReadLine();
            var cat = from c in db.Catagories 
                      select c;
            Console.WriteLine("Catagory List");
            int i=1;
            foreach(var item in cat)
            {
                Console.WriteLine(i + "." + item.CatagoryName);
                i++;
            }
            Console.WriteLine("Enter Catagory Name from list:");
            string CN=Console.ReadLine();
            var catname = (from c in db.Catagories
                          where c.CatagoryName == CN
                          select c).FirstOrDefault();
            p.Catagory = catname;
            db.Products.Add(p);
            db.SaveChanges();
        }
        private static void CreateCatagory()
        {
            Console.WriteLine("Catagory Details:");
            ProductDbContext db = new ProductDbContext();
            Catagory c = new Catagory();
            Console.Write("Enter Catagory Name:");
            c.CatagoryName = Console.ReadLine();
            db.Catagories.Add(c);
            db.SaveChanges();
        }
    }
}