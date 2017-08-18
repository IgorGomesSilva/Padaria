using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CasaDoPao.Startup))]
namespace CasaDoPao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
