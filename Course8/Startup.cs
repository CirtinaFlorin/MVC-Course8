using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Course8.Startup))]
namespace Course8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
