using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace YunTu.Lpw.Web.Views
{
    public abstract class LpwRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LpwRazorPage()
        {
            LocalizationSourceName = LpwConsts.LocalizationSourceName;
        }
    }
}
