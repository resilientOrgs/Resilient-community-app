using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reso.Startup))]
namespace Reso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
