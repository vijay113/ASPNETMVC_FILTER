using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASPNETMVC_FiltersSample.CustomFilter
{
    public class CustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Log("OnException in CustomExceptionFilter", filterContext.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];

            var message = String.Format(
               "{0} controller:{1} action:{2}", methodName, controllerName, actionName);

            Debug.WriteLine(message, "Action Filter Log");
        }
    }
}