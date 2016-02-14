using Autofac;
using Autofac.Integration.Mvc;
using AutofacSerilogIntegration;
using VehicleApp.Client.Web.Managers;
using VehicleApp.Domain.Context;
using Owin;
using System.Web.Mvc;

namespace VehicleApp.Client.Web
{
    public partial class Startup
    {
        public void ConfigureAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            var logger = ConfigureLogging();
            builder.RegisterLogger(logger);

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<CarManager>().As<ICarManager>();
            builder.RegisterType<EnquiryManager>().As<IEnquiryManager>();
            builder.RegisterType<CommentManager>().As<ICommentManager>();

            builder.RegisterType<CarContext>().As<CarContext>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}