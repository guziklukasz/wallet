using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wallet.Web.Startup))]
namespace Wallet.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
