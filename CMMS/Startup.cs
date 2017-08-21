using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMMS.Startup))]
namespace CMMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
