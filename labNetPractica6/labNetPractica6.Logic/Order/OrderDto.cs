using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic.Order
{
    public class OrderDto
    {
        public long? Id { get; set; }
        public string Ship { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        public string Address { get; set; }
    }
}
