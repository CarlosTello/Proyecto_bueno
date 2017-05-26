using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comunidadpro.Startup))]
namespace Comunidadpro
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
