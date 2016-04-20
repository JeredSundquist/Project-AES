using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AES.WebApplication.Startup))]
namespace AES.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
