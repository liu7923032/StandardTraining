using System.Threading.Tasks;
using TrainCore.Configuration.Dto;

namespace TrainCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
