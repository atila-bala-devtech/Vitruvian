using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vitruvian.UI.Startup))]
namespace Vitruvian.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
