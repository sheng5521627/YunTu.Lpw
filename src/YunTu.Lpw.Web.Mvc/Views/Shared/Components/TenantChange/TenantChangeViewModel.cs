using Abp.AutoMapper;
using YunTu.Lpw.Sessions.Dto;

namespace YunTu.Lpw.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
