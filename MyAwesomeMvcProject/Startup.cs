using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAwesomeMvcProject.Startup))]
namespace MyAwesomeMvcProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
