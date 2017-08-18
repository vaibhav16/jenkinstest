using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jenkinstest.Startup))]
namespace jenkinstest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
