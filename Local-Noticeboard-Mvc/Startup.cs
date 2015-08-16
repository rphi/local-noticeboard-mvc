using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Local_Noticeboard_Mvc.Startup))]
namespace Local_Noticeboard_Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
