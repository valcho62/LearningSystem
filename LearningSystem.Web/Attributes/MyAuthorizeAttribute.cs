﻿

using System.Linq;
using System.Web.Mvc;

namespace LearningSystem.Web.Attributes
{
    public class MyAuthorizeAttribute : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {

            var roles = Roles.Split(',');
            if (filterContext.HttpContext.Request.IsAuthenticated &&
                ! roles.Any(filterContext.HttpContext.User.IsInRole))
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "~/Views/Shared/Unauthorized.cshtml"
                };
            }
            else
            {
                 base.HandleUnauthorizedRequest(filterContext);
            }
           
        }
    }
}