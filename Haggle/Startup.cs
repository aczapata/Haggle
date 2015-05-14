using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Haggle.Startup))]
namespace Haggle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
