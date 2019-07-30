using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Unnati1Service.Startup))]

namespace Unnati1Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}