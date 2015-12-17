using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialNetwork.WebUi.Startup))]
namespace SocialNetwork.WebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
