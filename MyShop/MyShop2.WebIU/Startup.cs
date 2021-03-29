using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop2.WebIU.Startup))]
namespace MyShop2.WebIU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
