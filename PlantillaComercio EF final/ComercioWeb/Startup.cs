using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComercioWeb.Startup))]
namespace ComercioWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
