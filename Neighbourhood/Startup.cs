using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Neighbourhood.Startup))]
namespace Neighbourhood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
