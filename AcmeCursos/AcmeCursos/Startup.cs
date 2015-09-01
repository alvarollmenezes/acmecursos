using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AcmeCursos.Startup))]
namespace AcmeCursos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
