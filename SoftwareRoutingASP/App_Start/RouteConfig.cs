using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SoftwareRoutingASP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //route
            routes.MapRoute(
                    name:"TestLogin",
                    url:"Test/Login/{id}/{role}",
                    defaults: new {controller ="Test",action="Login"},
                    constraints: new {id="[1-9]+"}
                );
            routes.MapRoute(
                    name:"TestSearch",
                    url:"Test/{title}",
                    defaults: new {controller="Test",action="SearchByTitle"}

                );





            //Las rutas Default van al final
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
