using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Warframer.Startup))]
namespace Warframer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
