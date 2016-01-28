using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prinicipis_Capital.Startup))]
namespace Prinicipis_Capital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
