using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mySensorDataManager.Startup))]
namespace mySensorDataManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
