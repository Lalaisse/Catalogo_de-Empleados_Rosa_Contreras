using System.Web;
using System.Web.Mvc;

namespace Catálogo_de_Empleados_Rosa_Icela_Contreras_Ocampo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
