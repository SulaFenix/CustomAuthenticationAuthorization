using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessionSecurityWithASPNETMVC.Startup))]
namespace SessionSecurityWithASPNETMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
