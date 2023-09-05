using labNetPractica4.LINQ.ENTITIES;
using labNetPractica4.LINQ.LOGIC.Customer;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Customer.UI
{
    public class CustomersWithWARegionUI
    {
		public static void GetCustomersWithWARegion()
		{
			try
			{
				AppClean.ClearConsole();
				//CustomersWhitRegionWA customerWithRegionWA = new CustomersWhitRegionWA();
				//var customersList = customerWithRegionWA.GetConsulta();
				//PrintCustomersWithRegionWA(customersList);
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

		public static void PrintCustomersWithRegionWA(IEnumerable<Customers> query)
		{
			foreach (var item in query)
			{
				Messages.AppMessages.MessageCustomerWithWARegion(item);
			}
		}
	}
}
