using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopThaoMoc.Startup))]
namespace ShopThaoMoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
