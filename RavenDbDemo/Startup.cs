using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RavenDbDemo.Startup))]
namespace RavenDbDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
