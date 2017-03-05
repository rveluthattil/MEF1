using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MEF1.Startup))]
namespace MEF1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
