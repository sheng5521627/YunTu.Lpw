using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using YunTu.Lpw.Authorization.Users;
using YunTu.Lpw.Editions;

namespace YunTu.Lpw.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
