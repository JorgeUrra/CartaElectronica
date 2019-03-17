using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carta_Electronica.Startup))]
namespace Carta_Electronica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
