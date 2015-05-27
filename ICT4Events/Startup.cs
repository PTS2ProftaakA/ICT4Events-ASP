using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICT4Events.Startup))]
namespace ICT4Events
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
