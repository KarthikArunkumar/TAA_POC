using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello_Wrold.Startup))]
namespace Hello_Wrold
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
