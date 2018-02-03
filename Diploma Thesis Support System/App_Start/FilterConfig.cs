using System.Web;
using System.Web.Mvc;

namespace Diploma_Thesis_Support_System
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
