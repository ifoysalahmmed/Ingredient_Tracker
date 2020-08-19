using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IngredientTracker.Startup))]
namespace IngredientTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
