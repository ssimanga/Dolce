using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dolce.UI.Startup))]
namespace Dolce.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
