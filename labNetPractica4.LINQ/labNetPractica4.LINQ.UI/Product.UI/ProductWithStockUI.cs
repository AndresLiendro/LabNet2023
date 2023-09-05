using labNetPractica4.LINQ.LOGIC.Product;
using labNetPractica4.LINQ.LOGIC.Product.Dtos;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Product.UI
{
    public class ProductWithStockUI
    {
		public static void ObtenerProductosConStock()
		{
			try
			{
				AppClean.ClearConsole();
				ProductsWithStock productWithStock = new ProductsWithStock();
				var productsList = productWithStock.GetConsulta();
				PrintProductWithStock(productsList);
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

		public static void PrintProductWithStock(IEnumerable<ProductsWithStockDto> query)
		{
			foreach (var item in query)
			{
				Messages.AppMessages.MessageProductsWithStock(item);
			}
		}
	}
}
