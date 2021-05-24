using System.Web;
using System.Web.Mvc;

namespace csharp_crud_mvc_api_ef_sql
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
