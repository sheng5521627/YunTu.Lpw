using System.Threading.Tasks;
using Abp.Application.Services;
using YunTu.Lpw.Sessions.Dto;

namespace YunTu.Lpw.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
