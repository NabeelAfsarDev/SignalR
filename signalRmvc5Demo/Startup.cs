using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(signalRmvc5Demo.Startup))]
namespace signalRmvc5Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
