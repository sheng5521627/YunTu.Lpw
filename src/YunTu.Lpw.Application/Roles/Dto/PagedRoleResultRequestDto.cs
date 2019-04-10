using Abp.Application.Services.Dto;

namespace YunTu.Lpw.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

