using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Restourant.Manager.Configuration.Dto;

namespace Restourant.Manager.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ManagerAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
