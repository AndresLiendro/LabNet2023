using labNetPractica3.EF.Data;
using labNetPractica3.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica3.EF.Logic.Customer
{
    public class CustomerServicio : BasicLogic, ILogic<CustomerDto>
    {
        public IEnumerable<CustomerDto> GetAll()
        {
            var costumer = context.Customers
                   .Select(x => new CustomerDto
                    {
                       Id = x.CustomerID,
                       CompanyName = x.CompanyName,
                       ContactName = x.ContactName,
                       ContactTitle = x.ContactTitle,
                    }).ToList();
            return costumer;
        }
        public long Insert(CustomerDto dto)
        {
            using (context)
            {
                var NewCustomer = new Customers()
                {
                   CompanyName = dto.CompanyName,
                   ContactName = dto.ContactName,
                   ContactTitle = dto.ContactTitle,
                };

                context.Customers.Add(NewCustomer);
                context.SaveChanges();

                return NewCustomer.CustomerID.Length;
            }
        }

        public void Update(CustomerDto dto)
        {
            using (context)
            {
                var customer = context.Customers.FirstOrDefault(c => c.CustomerID.Equals(dto.Id));

                if (customer != null)
                {
                    customer.CompanyName = dto.CompanyName;
                    customer.ContactName = dto.ContactName;
                    customer.ContactTitle = dto.ContactTitle;

                    context.SaveChanges();
                }
            }
        }
        public void Delete(long ID)
        {
            using (context) 
            {
                var customer = context.Customers.FirstOrDefault(c => c.CustomerID.Equals(ID));

                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }
        }
    }
}

