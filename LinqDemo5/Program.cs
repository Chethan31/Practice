namespace LanguageEnhancements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<Product> products = ProductsDB.GetProducts();

            //1. List all products whose price in between 50K to 80K
            Console.WriteLine("Product Whose Price in between 50K to 80K are:");
            var pp = from p in products
                     where p.Price >= 50000 && p.Price <= 80000
                     select p.Name;
            foreach (var item in pp)
            {
                Console.WriteLine("-" + item);
            }
            Console.WriteLine();
            //2. Extract all products belongs to Laptops catagory
            Console.WriteLine("All products belongs to Laptops catagory are:");
            var pc = from p in products
                     where p.Catagory.Name == "Laptops"
                     select p.Name;
            foreach (var item in pc)
            {
                Console.WriteLine("-" + item);
            }
            Console.WriteLine();
            //3. Extract/Show Product Name and Catagory Name only
            //Console.WriteLine("Product Name:");
            //var pN = from p in products
            //         select p.Name;
            //foreach (var item in pN)
            //{
            //    Console.WriteLine("-" + item);
            //}

            //Console.WriteLine("Catagory Name:");
            //var Cn = from c in products
            //         group c by c.Catagory into g
            //         select new { Catagorys = g.Select(g => g.Catagory.Name).FirstOrDefault() };
            //foreach (var item in Cn)
            //{
            //    Console.WriteLine("-" + item);
            //}

            Console.WriteLine("Product Name and Catagory:");
            var pnc = from p in products
                      select new {p.Name,catagory=p.Catagory.Name };
            foreach (var item in pnc)
            {
                Console.Write("-Product: " + item.Name);
                Console.WriteLine(" && Catagory: " + item.catagory);
            }
            Console.WriteLine();
            //4. Show the costliest product name 
            Console.WriteLine("The costliest product name:");
            var pro = from p in products
                      where p.Price == products.Max(a => a.Price)
                      select p.Name;
            foreach (var item in pro)
            {
                Console.WriteLine("-" + item);
            }
            Console.WriteLine();
            //5. Show the cheepest product name and its price
            Console.WriteLine("The cheepest product:");
            var pr = from p in products
                     where p.Price == products.Min(a => a.Price)
                     select new {p.Name,p.Price};
            foreach (var item in pr)
            {
                Console.WriteLine("-" + "Name: "+item.Name);
                Console.WriteLine("-" + "Price: " + item.Price);
            }
            Console.WriteLine();
            //6. Show the 2nd and 3rd product details
            Console.WriteLine("Show the 2nd and 3rd product details:");
            var query= from p in products
                       select p;
            //var firstResult = query.First();
            var secondResult = query.Skip(1).Take(1).Single();
            var thirdResult = query.Skip(2).Take(1).Single();
            Console.WriteLine("The 2nd product details:");
            Console.WriteLine("Name: " + secondResult.Name);
            Console.WriteLine("Catagory: " + secondResult.Catagory.Name);
            Console.WriteLine("Price: " + secondResult.Price);
            Console.WriteLine();
            Console.WriteLine("The 3rd product details:");
            Console.WriteLine("Name: " + thirdResult.Name);
            Console.WriteLine("Catagory: " + thirdResult.Catagory.Name);
            Console.WriteLine("Price: " + thirdResult.Price);
            Console.WriteLine();
            //7. List all products in assending order of their price
            Console.WriteLine("All products in assending order of their price:");
            Console.WriteLine(" Name\t\tPrice");
            var ppr = from p in products
                      orderby p.Price ascending
                      select new { p.Name, p.Price };
            foreach (var item in ppr)
            {
                Console.WriteLine("-"+item.Name+" \t"+item.Price);
            }
            Console.WriteLine();
            //8. Count the no. of products belong to Tablets
            Console.WriteLine("The Number of products belong to Tablets:");
            var pt = from p in products
                     where p.Catagory.Name== "Tablets"
                     group p by p.Catagory.Name into cata
                     select new {count=cata.Count()};
            foreach (var item in pt)
            {
                Console.WriteLine(" "+item.count);
            }
            Console.WriteLine();
            //9. Show which catagory has costly product
            Console.WriteLine("The catagory has costly product:");
            var ppc = from p in products
                      where p.Price == products.Max(a => a.Price)
                      select new { catagory = p.Catagory.Name,p.Price};
            foreach (var item in ppc)
            {
                Console.WriteLine("-" + item.catagory+"  "+item.Price);
            }
            Console.WriteLine();
            //10. Show which catagory has less products
            Console.WriteLine("The catagory has less products:");
            var plcc = from p in products
                     group p by p.Catagory.Name into cata
                     select new { catagory = cata.Key,count = cata.Count() };
            var plc = from p in plcc
                      where p.count == plcc.Min(a =>a.count)
                      select new { catagory = p.catagory};
            foreach (var item in plc)
            {
                Console.WriteLine("-" + item.catagory);
            }
            Console.WriteLine();
            //11. Save all products into XML document	



        }

    }
    class ProductsDB
    {
        public static List<Product> GetProducts()
        {
            Catagory cat1 = new Catagory { CatagoryID = 101, Name = "Laptops" };
            Catagory cat2 = new Catagory { CatagoryID = 201, Name = "Mobiles" };
            Catagory cat3 = new Catagory { CatagoryID = 301, Name = "Tablets" };

            Product p1 = new Product { ProductID = 1, Name = "Dell XPS 13", Catagory = cat1, Price = 90000 };
            Product p2 = new Product { ProductID = 2, Name = "HP 430", Catagory = cat1, Price = 50000 };
            Product p3 = new Product { ProductID = 3, Name = "IPhone 6", Catagory = cat2, Price = 80000 };
            Product p4 = new Product { ProductID = 4, Name = "Galaxy S6", Catagory = cat2, Price = 74000 };
            Product p5 = new Product { ProductID = 5, Name = "IPad Pro", Catagory = cat3, Price = 44000 };

            cat1.Products.Add(p1);
            cat1.Products.Add(p2);
            cat2.Products.Add(p3);
            cat2.Products.Add(p4);
            cat3.Products.Add(p5);

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);

            return products;
        }
    }
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Catagory Catagory { get; set; }
    }
    class Catagory
    {
        public int CatagoryID { get; set; }
        public string Name { get; set; }
        public List<Product> Products = new List<Product>();
    }
}
