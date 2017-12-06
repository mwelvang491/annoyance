using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NorthwindClass.Startup))]
namespace NorthwindClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
