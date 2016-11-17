using Owin;
using System.Web.Http;

namespace WebApiTemplate
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            CorsConfig.Configure(app);

            AutofacConfig.Configure(app, config);

            WebApiConfig.Configure(config);

            SwaggerConfig.Register(config);

            app.UseWebApi(config);
        }
    }
}