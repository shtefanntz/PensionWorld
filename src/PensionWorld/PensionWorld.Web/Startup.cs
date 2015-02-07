using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PensionWorld.Web.Startup))]
namespace PensionWorld.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
