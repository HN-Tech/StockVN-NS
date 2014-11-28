using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhimHang_Lookup.Startup))]
namespace PhimHang_Lookup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
