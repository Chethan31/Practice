using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogApp.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        public string CatagoryName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
