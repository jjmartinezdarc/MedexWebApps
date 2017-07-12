using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedexWebApps.Startup))]
namespace MedexWebApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
