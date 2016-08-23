using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClientForKOMK.Startup))]
namespace ClientForKOMK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
