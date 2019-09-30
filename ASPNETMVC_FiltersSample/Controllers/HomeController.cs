using ASPNETMVC_FiltersSample.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC_FiltersSample.Controllers
{
    [CustomLogActionFilter]
    public class HomeController : Controller
    {        

        [OutputCache(Duration = 15)]
        public string Index()
        {
            return "This is ASP.Net MVC Filters Tutorial";          
        }


        [OutputCache(Duration = 20)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

    }
}