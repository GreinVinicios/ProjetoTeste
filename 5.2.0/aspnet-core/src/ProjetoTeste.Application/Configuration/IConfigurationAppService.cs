using System.Threading.Tasks;
using ProjetoTeste.Configuration.Dto;

namespace ProjetoTeste.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
