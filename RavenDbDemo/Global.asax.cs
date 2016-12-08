using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Raven.Client;
using Raven.Client.Document;

namespace RavenDbDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
       // private const string RavenSessionKey = "RavenDb.Session";
        private static DocumentStore documentStore;


        protected void Application_Start()
        {
          documentStore = new DocumentStore { Url = "http://localhost:8080/" };
            documentStore.Initialize();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //public static IDocumentSession CurrentSession => (IDocumentSession)HttpContext.Current.Items[RavenSessionKey];
    }
}
