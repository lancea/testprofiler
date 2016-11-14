using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestProfiler.Startup))]
namespace TestProfiler
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
