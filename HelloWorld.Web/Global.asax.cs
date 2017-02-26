using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using HelloWorld.Web.Config;
using StructureMap;
using StructureMap.Web.Pipeline;

namespace HelloWorld.Web
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            IContainer container = TypeConfig.RegisterTypes();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            if (exception != null)
            {
                Server.ClearError();

                try
                {
                    HttpUnhandledException unhandledException = exception as HttpUnhandledException;
                    exception = unhandledException != null
                        ? (unhandledException.InnerException as HttpException ?? unhandledException)
                        : exception;

                    // log the error
                }
                catch
                {
                }

                // possibly redirect to error page
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            HttpContextLifecycle.DisposeAndClearAll();
        }
    }
}