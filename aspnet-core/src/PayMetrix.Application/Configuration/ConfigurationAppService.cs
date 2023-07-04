using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PayMetrix.Configuration.Dto;

namespace PayMetrix.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PayMetrixAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
