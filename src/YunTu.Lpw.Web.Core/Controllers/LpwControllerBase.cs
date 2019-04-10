using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace YunTu.Lpw.Controllers
{
    public abstract class LpwControllerBase: AbpController
    {
        protected LpwControllerBase()
        {
            LocalizationSourceName = LpwConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
