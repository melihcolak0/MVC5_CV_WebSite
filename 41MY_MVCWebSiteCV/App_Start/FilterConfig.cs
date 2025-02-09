using System.Web;
using System.Web.Mvc;

namespace _41MY_MVCWebSiteCV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
