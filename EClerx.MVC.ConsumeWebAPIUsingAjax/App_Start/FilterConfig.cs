using System.Web;
using System.Web.Mvc;

namespace EClerx.MVC.ConsumeWebAPIUsingAjax
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
