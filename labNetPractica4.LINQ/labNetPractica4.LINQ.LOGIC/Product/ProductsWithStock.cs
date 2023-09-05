using labNetPractica4.LINQ.LOGIC.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product
{
    public class ProductsWithStock : ContextDb, IGet<ProductsWithStockDto>
    {
        public IEnumerable<ProductsWithStockDto> GetConsulta()
        {
            using (context)
            {
                return context.Products
                    .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3)
                    .Select(p => new ProductsWithStockDto
                    {
                        Name = p.ProductName,
                        ProductStock = (short)p.UnitsInStock,
                        UnitPrice = (decimal)p.UnitPrice
                    }).ToList();
            }
        }
    }
}
