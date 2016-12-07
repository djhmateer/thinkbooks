using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThinkBooksWebsiteBootstrap.Startup))]
namespace ThinkBooksWebsiteBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
