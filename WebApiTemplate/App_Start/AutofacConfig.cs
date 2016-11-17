using Autofac;
using Autofac.Integration.WebApi;
using Owin;
using System.Web.Http;

namespace WebApiTemplate
{
    public class AutofacConfig
    {
        internal static void Configure(IAppBuilder app, HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder
                .RegisterApiControllers(typeof(Startup).Assembly)
                .InstancePerRequest();

            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
        }
    }
}