using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaRental.Startup))]
namespace CaRental
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
