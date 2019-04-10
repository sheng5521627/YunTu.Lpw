using System.Threading.Tasks;
using Abp.Application.Services;
using YunTu.Lpw.Authorization.Accounts.Dto;

namespace YunTu.Lpw.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
