using labNetPractica3.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic.Customer
{
    public class CustomerServicio : ILogic<CustomerDto>
    {

        public IEnumerable<CustomerDto> GetAll()
        {
            using (var context = new NorthwindContext())
            {
                return context.Customers.Select(x => new CustomerDto
                {
                    Id = x.CustomerID,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName,
                    ContactTitle = x.ContactTitle,
                }).ToList();
            }
        }
        public long Insert(CustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerDto dto)
        {
            throw new NotImplementedException();
        }
        public void Delete(decimal ID)
        {
            throw new NotImplementedException();
        }

    }
}

