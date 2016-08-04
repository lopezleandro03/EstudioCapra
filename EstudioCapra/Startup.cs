using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudioCapra.Startup))]
namespace EstudioCapra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }               

    }
}
