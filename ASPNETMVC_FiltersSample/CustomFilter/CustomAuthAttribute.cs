using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC_FiltersSample.CustomFilter
{
    public class CustomAuthAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            throw new NotImplementedException();
        }               

    }

    public class CustomizedAuth : AuthorizeAttribute
    {

        
        // Summary:
        //     Called when a process requests authorization.
              
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        //
        // Summary:
        //     When overridden, provides an entry point for custom authorization checks.
        //// Returns:
        //     true if the user is authorized; otherwise, false.
        //
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return base.AuthorizeCore(httpContext);
        }


        //
        // Summary:
        //     Processes HTTP requests that fail authorization.
        //
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
        }


        //
        // Summary:
        //     Called when the caching module requests authorization.
        //
        protected override HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
        {
            return base.OnCacheAuthorization(httpContext);
        }

    }

}