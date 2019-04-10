using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using YunTu.Lpw.Configuration.Dto;

namespace YunTu.Lpw.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LpwAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
