using labNetPractica3.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic
{
    public abstract class BasicLogic
    {
        protected NorthwindContext context;

        public BasicLogic()
        {
            context = new NorthwindContext();
        }
    }
}
