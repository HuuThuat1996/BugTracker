using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BugTracker
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
              name: "Register",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Register", action = "Register", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "testermanager",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "TesterManager", action = "Index", id = UrlParameter.Optional }
         );
        }
    }
}
