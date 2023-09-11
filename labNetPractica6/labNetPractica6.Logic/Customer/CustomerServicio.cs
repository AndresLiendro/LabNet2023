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
        public bool Insert(CustomerDto dto)
        {
            try
            {
                var NewCustomer = new Customers()
                {
                    CompanyName = dto.CompanyName,
                    ContactName = dto.ContactName,
                    ContactTitle = dto.ContactTitle,
                };

                context.Customers.Add(NewCustomer);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(CustomerDto dto)
        {
            try
            {
                var customer = context.Customers.FirstOrDefault(c => c.CustomerID.Equals(dto.Id));

                if (customer != null)
                {
                    customer.CompanyName = dto.CompanyName;
                    customer.ContactName = dto.ContactName;
                    customer.ContactTitle = dto.ContactTitle;

                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(long ID)
        {
            try
            {
                var customer = context.Customers.FirstOrDefault(c => c.CustomerID.Equals(ID));

                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

