using System.Threading.Tasks;
using Restourant.Manager.Configuration.Dto;

namespace Restourant.Manager.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
