using System.Collections.Generic;
using YunTu.Lpw.Roles.Dto;
using YunTu.Lpw.Users.Dto;

namespace YunTu.Lpw.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
