using labNetPractica4.LINQ.LOGIC.Categories;
using labNetPractica4.LINQ.UI.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica4.LINQ.UI.Product.UI
{
    public class ProductsCaregoriesUI
    {
        public static void ObtenerProductCategories()
        {
            try
            {
                AppClean.ClearConsole();
                CategoriesServicio productCategories = new CategoriesServicio();
                var productCategoriesList = productCategories.GetConsulta();
                PrintProductsCategory(productCategoriesList);

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

        public static void PrintProductsCategory(IEnumerable<CategoriesDto> query)
        {
            foreach (var item in query)
            {
                Messages.AppMessages.MessageProductCategorie(item);
            }
        }
    }
}
