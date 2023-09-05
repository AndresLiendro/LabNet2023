using labNetPractica4.LINQ.LOGIC.Customers;
using labNetPractica4.LINQ.LOGIC.Customers.Dtos;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Customer.UI
{
    public class CustomersMayMinUI
    {
		public static void GetCustomersMayMen()
		{
			try
			{
				AppClean.ClearConsole();
				CustomerMayMin customerMayulaMinu = new CustomerMayMin();
				var customerList = customerMayulaMinu.GetConsulta();
				PrintCustomerMayMin(customerList);
			}
			catch (Exception ex)
			{
				Messages.AppMessages.ExceptionMessage(ex);
			}
			finally
			{
				Tries.TryAgain();
			}
		}

		public static void PrintCustomerMayMin(IEnumerable<CustomerMayMinDto> query)
		{
			foreach (var item in query)
			{
				Messages.AppMessages.MessageCustomerMayMen(item);
			}
		}
	}
}
