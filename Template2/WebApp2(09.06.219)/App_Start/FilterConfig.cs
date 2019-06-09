using System.Web;
using System.Web.Mvc;

namespace WebApp2_09._06._219_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
