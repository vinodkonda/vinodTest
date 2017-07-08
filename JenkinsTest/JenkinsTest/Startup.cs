using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsTest.Startup))]
namespace JenkinsTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
