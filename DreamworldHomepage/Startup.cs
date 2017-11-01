using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamworldHomepage.Startup))]
namespace DreamworldHomepage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
