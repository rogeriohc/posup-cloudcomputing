using System.Web;
using System.Web.Mvc;

namespace PosUP_CloudComputing_WebAPIDotNET
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
