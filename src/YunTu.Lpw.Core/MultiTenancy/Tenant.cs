using Abp.MultiTenancy;
using YunTu.Lpw.Authorization.Users;

namespace YunTu.Lpw.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
