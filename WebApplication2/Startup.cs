using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplication2.StartupOwin))]

namespace WebApplication2
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
