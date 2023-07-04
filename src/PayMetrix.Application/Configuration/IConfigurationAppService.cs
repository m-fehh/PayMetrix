using System.Threading.Tasks;
using PayMetrix.Configuration.Dto;

namespace PayMetrix.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
