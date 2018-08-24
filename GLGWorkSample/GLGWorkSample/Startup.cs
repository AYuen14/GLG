using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GLGWorkSample.Startup))]
namespace GLGWorkSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
