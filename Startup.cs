using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GbegiriWeb.Startup))]
namespace GbegiriWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
