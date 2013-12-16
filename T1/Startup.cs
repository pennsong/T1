using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(T1.Startup))]
namespace T1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
