using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testmvc111.Startup))]
namespace testmvc111
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
