using System.Collections.Generic;
using YunTu.Lpw.Roles.Dto;

namespace YunTu.Lpw.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
