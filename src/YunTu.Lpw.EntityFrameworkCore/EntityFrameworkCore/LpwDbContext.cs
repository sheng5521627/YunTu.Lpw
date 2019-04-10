using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using YunTu.Lpw.Authorization.Roles;
using YunTu.Lpw.Authorization.Users;
using YunTu.Lpw.MultiTenancy;

namespace YunTu.Lpw.EntityFrameworkCore
{
    public class LpwDbContext : AbpZeroDbContext<Tenant, Role, User, LpwDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LpwDbContext(DbContextOptions<LpwDbContext> options)
            : base(options)
        {
        }
    }
}
