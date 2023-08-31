using labNetPractica3.EF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic.Customer
{
    public class CustomersServicio : ILogic<CustomersDto>
    {

        public IList<CustomersDto> GetAll()
        {
            using (var context = new NorthwindContext())
            {
                return context.Customers.Where(x => x.CompanyName.Contains("")).Select(x => new CustomersDto
                {
                    Id = x.CustomerID,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName,
                    ContactTitle = x.ContactTitle,
                }).ToList();
            }
        }
        public long Insert(CustomersDto dto)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomersDto dto)
        {
            throw new NotImplementedException();
        }
        public void Delete(CustomersDto dto)
        {
            throw new NotImplementedException();
        }

    }
}

