using Microsoft.AspNet.Identity;
using SignalrPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SignalrPractice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //RouteTable.Routes.MapHubs(); ----obsoelete

        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // routes registered here
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           // RouteTable.Routes.MapHubs();
        }
        //try method get user async read carfully study
        

    }
}
