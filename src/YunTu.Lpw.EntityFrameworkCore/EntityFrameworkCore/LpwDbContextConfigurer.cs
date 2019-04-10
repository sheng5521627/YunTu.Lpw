using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace YunTu.Lpw.EntityFrameworkCore
{
    public static class LpwDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LpwDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LpwDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
