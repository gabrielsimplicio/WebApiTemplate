using Microsoft.Owin.Cors;
using Owin;

namespace WebApiTemplate
{
    public class CorsConfig
    {
        public static void Configure(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
        }
    }
}