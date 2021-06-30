using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookManager47.Startup))]
namespace BookManager47
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
