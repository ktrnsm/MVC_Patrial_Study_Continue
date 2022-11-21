using System.Web;
using System.Web.Mvc;

namespace MVC_Patrial_Study_Continue
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
