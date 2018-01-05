using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(timeManager_v1.Startup))]
namespace timeManager_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
