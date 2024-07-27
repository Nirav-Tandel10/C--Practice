using System.Web;
using System.Web.Mvc;

namespace MEAL_PROJECT_AUTHAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
