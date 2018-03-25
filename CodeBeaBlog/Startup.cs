using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeBeaBlog.Startup))]
namespace CodeBeaBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
