using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using YunTu.Lpw.Configuration;
using YunTu.Lpw.Web;

namespace YunTu.Lpw.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LpwDbContextFactory : IDesignTimeDbContextFactory<LpwDbContext>
    {
        public LpwDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LpwDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LpwDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LpwConsts.ConnectionStringName));

            return new LpwDbContext(builder.Options);
        }
    }
}
