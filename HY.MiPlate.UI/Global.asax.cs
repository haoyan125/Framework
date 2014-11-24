using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

namespace HY.MiPlate.UI
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            HY.MiPlate.Routes.DefaultRoute.RegisterRoutes(RouteTable.Routes);
            var container = IocResolver.Configure();
            ControllerBuilder.Current.SetControllerFactory(new IocControllerFactory(container));
            //GlobalConfiguration.Configuration.ServiceResolver.SetResolver(new StructureMapDependencyResolver(container));
        }

        public static IContainer ConfigureDependencies()
        {
            IContainer container = new Container();

            container.Configure(x => x.Scan(scan =>
            {
                scan.Assembly("HY.MiPlate.UI.Repository");
                scan.Assembly("HY.MiPlate.UI.Domain");
            }));
            return container;
        }
    }
}