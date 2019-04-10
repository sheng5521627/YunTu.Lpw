using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YunTu.Lpw.MultiTenancy.Dto;

namespace YunTu.Lpw.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

