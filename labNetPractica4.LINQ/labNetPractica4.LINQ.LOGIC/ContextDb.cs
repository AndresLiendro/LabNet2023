using labNetPractica4.LINQ.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.LOGIC
{
    public class ContextDb
    {
        protected NorthwindContext context;

        public ContextDb()
        {
            context = new NorthwindContext();
        }
    }
}
