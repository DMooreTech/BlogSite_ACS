using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogSite_Final.Startup))]
namespace BlogSite_Final
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
