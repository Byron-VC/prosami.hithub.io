using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prosamiWeb.Startup))]
namespace prosamiWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
