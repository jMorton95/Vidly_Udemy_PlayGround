using System.Web;
using System.Web.Mvc;

namespace Udemy_ASP.NET_MVC5_Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
