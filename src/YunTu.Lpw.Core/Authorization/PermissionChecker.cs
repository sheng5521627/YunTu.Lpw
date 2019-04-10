using Abp.Authorization;
using YunTu.Lpw.Authorization.Roles;
using YunTu.Lpw.Authorization.Users;

namespace YunTu.Lpw.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
