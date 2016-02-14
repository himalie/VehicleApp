using AutoMapper;
using VehicleApp.Client.Web.Mapping;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace VehicleApp.Client.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Automapper configurations.
            Mapper.Initialize(config => {
                config.AddProfile<CarMappingProfile>();
                config.AddProfile<EnquiryMappingProfile>();
                config.AddProfile<CommentMappingProfile>();
            });

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
