using labNetPractica4.LINQ.LOGIC.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product
{
    public class ProductWithoutStockMayMen : ContextDb, IGet<ProductsWithoutStockMayMenDto>
    {
        public IEnumerable<ProductsWithoutStockMayMenDto> GetConsulta()
        {
            using (context) 
            {
                var query = from p in context.Products
                            orderby p.UnitsInStock descending
                            select new ProductsWithoutStockMayMenDto
                            {
                                Name = p.ProductName,
                                Stock = (short)p.UnitsInStock
                            };
                return query.ToList();
            }
        }
    }
}
