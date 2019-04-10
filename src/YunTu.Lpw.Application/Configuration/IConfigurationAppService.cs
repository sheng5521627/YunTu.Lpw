using System.Threading.Tasks;
using YunTu.Lpw.Configuration.Dto;

namespace YunTu.Lpw.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
