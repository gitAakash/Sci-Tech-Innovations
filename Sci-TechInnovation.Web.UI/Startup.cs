using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sci_TechInnovation.Web.UI.Startup))]
namespace Sci_TechInnovation.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
