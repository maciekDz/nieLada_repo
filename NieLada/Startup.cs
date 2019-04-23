using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NieLada.Startup))]
namespace NieLada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
