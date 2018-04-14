using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AttendanceAPI.Startup))]

namespace AttendanceAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
