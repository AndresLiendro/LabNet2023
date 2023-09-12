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
        public List<CustomerDto> GetAll()
        {
            IEnumerable<Customers> customers = context.Customers.AsEnumerable();

            List<CustomerDto> result = customers
                .Select(x => new CustomerDto
                {
                    Id = x.CustomerID,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName,
                    ContactTitle = x.ContactTitle,
                }).ToList();

            return result;
        }
        public bool Insert(CustomerDto dto)
        {
            var NewCustomer = new Customers()
            {
                CompanyName = dto.CompanyName,
                ContactName = dto.ContactName,
                ContactTitle = dto.ContactTitle,
            };

            context.Customers.Add(NewCustomer);
            return context.SaveChanges() > 0;
        }

        public bool Update(CustomerDto dto)
        {
            bool result = false;
            Customers customer = context.Customers.FirstOrDefault(c => c.CustomerID.Equals(dto.Id));

            if (customer != null)
            {
                customer.CompanyName = dto.CompanyName;
                customer.ContactName = dto.ContactName;
                customer.ContactTitle = dto.ContactTitle;

                result = context.SaveChanges() > 0;
            }

            return result;
        }
        public bool Delete(int ID)
        {
            bool result = false;
            Customers customer = context.Customers.FirstOrDefault(c => c.CustomerID.Equals(ID));

            if (customer != null)
            {
                context.Customers.Remove(customer);
                return result = context.SaveChanges() > 0;
            }

            return result;
        }

        public Customers GetById(int id)
        {
            return context.Customers.FirstOrDefault(e => e.CustomerID == id.ToString());
        }
    }
}

