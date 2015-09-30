using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreelanceManagement.Startup))]
namespace FreelanceManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
