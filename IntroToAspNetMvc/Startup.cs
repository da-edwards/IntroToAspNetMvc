using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntroToAspNetMvc.Startup))]
namespace IntroToAspNetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
