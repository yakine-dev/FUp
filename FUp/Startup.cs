using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FUp.Startup))]
namespace FUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
