using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthReportingProject.Startup))]
namespace HealthReportingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
