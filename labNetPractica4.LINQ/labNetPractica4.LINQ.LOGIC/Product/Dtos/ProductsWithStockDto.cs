using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product.Dtos
{
    public class ProductsWithStockDto
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int ProductStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
