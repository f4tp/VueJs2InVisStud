using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VueFromYoutube.Startup))]
namespace VueFromYoutube
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
