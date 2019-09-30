using ASPNETMVC_FiltersSample.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC_FiltersSample.Controllers
{

    /// <summary>
    /// Customized Filters can Apply on 3 levels:-
    /// 1) Action level
    /// 2) Controller level 
    /// 3) Global level  --> check global.cs file to know about implementation in global.cs
    ///
    /// if all level contains same type of filters like- action filters.
    /// then , they will execute in Recursion order of Global(executing()) -> Controller(executing()) -> Action(executing() -> Executed()) -> Controller(Executed()) -> Global(Executed()).
    /// </summary>


    //[CustomLogFilter]     (first way of Implementation)
    //[CustomLogActionFilter] (second way of Implementation)
    // [CustomizedAuth]   ( Customised Autherization FIlter )
    //[CustomExceptionFilter]  ( Customised Exceptional Filter)
    public class HomeController : Controller
    {        

        [OutputCache(Duration = 15)]
        // [CustomLogActionFilter]
        public string Index()
        {
            return "This is ASP.Net MVC Filters Tutorial";          
        }


        [OutputCache(Duration = 20)]
        // [CustomLogActionFilter]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }

        [CustomExceptionFilter]
        public string GetValue()
        {
            throw new Exception("Error in GetValue.");            
        }

    }
}