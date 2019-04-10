using Abp.AspNetCore.Mvc.ViewComponents;

namespace YunTu.Lpw.Web.Views
{
    public abstract class LpwViewComponent : AbpViewComponent
    {
        protected LpwViewComponent()
        {
            LocalizationSourceName = LpwConsts.LocalizationSourceName;
        }
    }
}
