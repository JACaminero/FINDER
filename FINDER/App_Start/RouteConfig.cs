using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FINDER
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
            routes.MapRoute(
                name: "Crud",
                url: "{controller}/{action}",
                defaults: new { controller = "CRUD", action = "CrudBuilder", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Update",
                url: "{controller}/{action}",
                defaults: new { controller = "CRUD", action = "Update"}
                );

            //routes.MapRoute(
            //    name: "SelectById",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "CRUD", action = "SelectById", id = UrlParameter.Optional }
            //    );

            routes.MapRoute(
                name: "SelectAll",
                url: "{controller}/{action}",
                defaults: new { controller = "CRUD", action = "SelectAll" }
                );

            routes.MapRoute(
                name: "Profile",
                url: "{controller}/{action}",
                defaults: new { controller = "ShowProfile", action = "Index" }
                );
        }
    }
}
