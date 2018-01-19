using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SpotlightExpress.MobileAppService.Startup))]

namespace SpotlightExpress.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}