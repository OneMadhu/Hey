using MVCPluralsight.Infrastructure;
using System.Web;
using System.Web.Mvc;

namespace MVCPluralsight
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ErrorFilterHandler());
        }
    }
}
