using System.Web;
using System.Web.Mvc;

namespace TP2_Triangulo__FI13005258_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
