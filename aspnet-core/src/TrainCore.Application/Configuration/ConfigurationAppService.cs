using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TrainCore.Configuration.Dto;

namespace TrainCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TrainCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
