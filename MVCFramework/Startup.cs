using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFramework.Startup))]
namespace MVCFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
