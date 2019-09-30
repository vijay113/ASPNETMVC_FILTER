using ASPNETMVC_FiltersSample.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC_FiltersSample.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Customized Filter added in GlobalfilterCollection.
            filters.Add(new CustomLogFilter());
        }
    }
}