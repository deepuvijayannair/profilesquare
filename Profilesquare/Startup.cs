using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Profilesquare.Startup))]
namespace Profilesquare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
