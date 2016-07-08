using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECUtilities.Startup))]
namespace ECUtilities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
