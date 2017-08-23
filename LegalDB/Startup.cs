using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LegalDB.Startup))]
namespace LegalDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
