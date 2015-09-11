using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlainMVC.Startup))]
namespace PlainMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
    }
}
