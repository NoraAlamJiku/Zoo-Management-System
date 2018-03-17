using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZooManagementSystemApp.Startup))]
namespace ZooManagementSystemApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
