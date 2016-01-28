using System.Web;
using System.Web.Mvc;

namespace Prinicipis_Capital
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
