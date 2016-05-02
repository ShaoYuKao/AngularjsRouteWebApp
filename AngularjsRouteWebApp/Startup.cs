using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularjsRouteWebApp.Startup))]
namespace AngularjsRouteWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
