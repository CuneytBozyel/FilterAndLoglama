using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilterAndLog.Startup))]
namespace FilterAndLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
