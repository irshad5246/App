using App.Services;
using App.Shared.Helpers;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App.Web.Startup))]
namespace App.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            var languageResource = LanguagesService.Instance.GetLanguageResources();
            LocalizationHelper.LoadResources(languageResource);
        }
    }
}
