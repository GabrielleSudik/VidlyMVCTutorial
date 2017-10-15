using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidlyMVCTutorial
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //we'll write this next thing ourselves, using newest MS syntax:
            //it automatically updates Routes when we update the controller (I think)
            //we must define an attribute in the controller

            routes.MapMvcAttributeRoutes();


            //define routes from most to least specific

            //here's the one we wrote:
            //just for practice. MS has a better way (see route, above)
            //routes.MapRoute
            //    ("MoviesByReleaseDate", "movies/released/{year}/{month}",
            //    new { controller = "Movies", action = "ByReleaseDate" },
            //    new { year = @"2015|2016", month = @"\d{2}"});    

            //this was was here already
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
