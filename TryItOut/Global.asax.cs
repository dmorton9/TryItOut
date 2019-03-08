using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TryItOut;
using TryItOut.App_Start;
using TryItOut.Helpers.Logger;
using System.Web.Http;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]

namespace TryItOut
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // *************
            // Model binders
            // *************
            BindersConfig.RegisterBinders();

            // **************
            // IoC initialise
            // **************

            // **********
            // Automapper
            // **********
            AutoMapperConfig.RegisterMappers();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            RouteData routeData = RouteTable.Routes.GetRouteData(new HttpContextWrapper(HttpContext.Current));
            //var action = routeData.GetRequiredString("action");
            //var controller = routeData.GetRequiredString("controller");

            /* set/create unit of work according to controller/action */

        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map handler");
        }

        protected void Application_PostMapRequesthandler()
        {
            Debug.WriteLine("Post Map handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Request state");
        }

        protected void Application_PreRequestHandlerexecute()
        {
            Debug.WriteLine("PrerequestHandler Execute");
        }

        protected void Application_PostRequesthandlerExecute()
        {
            Debug.WriteLine("Postrequesthandler Execute");
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            int unitOfWorkId = 0;
        }

        protected void Application_End()
        {
            Debug.WriteLine("End");
        }
    }
}
