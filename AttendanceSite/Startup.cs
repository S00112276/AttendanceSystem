using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AttendanceSite.Startup))]
namespace AttendanceSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
