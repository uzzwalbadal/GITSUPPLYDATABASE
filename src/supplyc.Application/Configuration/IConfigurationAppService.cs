using System.Threading.Tasks;
using supplyc.Configuration.Dto;

namespace supplyc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
