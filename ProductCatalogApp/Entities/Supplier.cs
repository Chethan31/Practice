using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogApp.Entities
{
    public class Supplier : Person
    {
       // public int SupplierID { get; set; } 
       // public string SupplierName { get; set; }
       public int Rank { get; set; }
       public string GST { get; set; }
       public List<Product> Products { get; set; }= new List<Product>();
    }
}
