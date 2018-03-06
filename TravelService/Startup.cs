using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravelService.Startup))]
namespace TravelService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}