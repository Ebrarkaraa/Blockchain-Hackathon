using System.Web;
using System.Web.Mvc;

namespace E_Ticaret_BlockChain
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
