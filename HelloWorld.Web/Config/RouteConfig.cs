using System.Web.Mvc;
using System.Web.Routing;

namespace HelloWorld.Web.Config
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // home
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "Home" });

            // error
            routes.MapRoute(
                name: "Error",
                url: "{*url}",
                defaults: new { controller = "Error", action = "Error" }
            );
        }
    }
}