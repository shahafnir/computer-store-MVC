using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(computer_store_MVC.Startup))]
namespace computer_store_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
