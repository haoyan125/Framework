using System.Web.Mvc;
using System.Web.Routing;
using HY.MiPlate.Routes.Constraints;

namespace HY.MiPlate.Routes
{
    public sealed class DefaultRoute 
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "DefaultRoute",
                url: string.Empty,
                defaults:
                    new
                    {
                        controller = "Default",
                        action = "Index",
                        LanguageCode = "en-GB"
                    });

            routes.MapRoute(
                           "DataRoute",
                           "{RouteType}/{controller}/{action}/{id}",
                          new { id = UrlParameter.Optional },
                         new { RouteType = new DataRouteConstraint() },
                          new string[] { "HY.MiPlate.UI.Controllers.Data" });
        }
    }
}
