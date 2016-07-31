using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(codename_orbit.Startup))]
namespace codename_orbit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
