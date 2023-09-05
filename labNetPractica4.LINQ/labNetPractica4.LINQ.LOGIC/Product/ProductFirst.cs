using labNetPractica4.LINQ.LOGIC.Product.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC.Product
{
    public class ProductFirst : ContextDb
    {
        protected void GetConsult()
        {
            using (context)
            {
                var query = context.Products.First();
                ProductMessage.FirstProductMessage(query);
            }
        }
    }
}
