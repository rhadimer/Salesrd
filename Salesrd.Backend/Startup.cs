using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Salesrd.Backend.Startup))]
namespace Salesrd.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
