using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eMiLyWebNet.Startup))]
namespace eMiLyWebNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
