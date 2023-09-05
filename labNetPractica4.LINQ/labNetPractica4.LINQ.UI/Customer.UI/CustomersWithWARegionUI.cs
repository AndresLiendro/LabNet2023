using labNetPractica4.LINQ.ENTITIES;
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
				CustomerFirstThreeRow customerPorRegionWA = new CustomerFirstThreeRow();
				var customersList = customerPorRegionWA.GetConsulta();
				ImprimirCustomerConRegionWA(customersList);
			}
			catch (Exception ex)
			{

				Mensajes.MensajeExcepcion(ex);
			}
			finally
			{
				Intentos.VolverAIntentarlo();
			}
		}

		public static void ImprimirCustomerConRegionWA(IEnumerable<Customers> query)
		{
			foreach (var item in query)
			{
				Mensajes.MensajeCustomerConRegionWA(item);
			}
		}
	}
}
