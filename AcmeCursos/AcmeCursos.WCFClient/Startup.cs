using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcmeCursos.WCFClient.Startup))]
namespace AcmeCursos.WCFClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
