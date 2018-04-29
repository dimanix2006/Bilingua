using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bilingua.Startup))]
namespace Bilingua
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
