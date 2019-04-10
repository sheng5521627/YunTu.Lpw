using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YunTu.Lpw.Authorization;

namespace YunTu.Lpw
{
    [DependsOn(
        typeof(LpwCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LpwApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LpwAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LpwApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
