using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using YunTu.Lpw.Configuration;

namespace YunTu.Lpw.Web.Host.Startup
{
    [DependsOn(
       typeof(LpwWebCoreModule))]
    public class LpwWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LpwWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LpwWebHostModule).GetAssembly());
        }
    }
}
