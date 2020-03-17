using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProjetoTeste.Configuration.Dto;

namespace ProjetoTeste.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProjetoTesteAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
