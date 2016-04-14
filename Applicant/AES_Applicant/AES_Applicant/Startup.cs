using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AES_Applicant.Startup))]
namespace AES_Applicant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
