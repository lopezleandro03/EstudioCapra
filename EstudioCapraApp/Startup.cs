using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudioCapraApp.Startup))]
namespace EstudioCapraApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
