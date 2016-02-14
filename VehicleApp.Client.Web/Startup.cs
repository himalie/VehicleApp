using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleApp.Client.Web.Startup))]
namespace VehicleApp.Client.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAutofac(app);
            ConfigureAuth(app);
        }
    }
}
