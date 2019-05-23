using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace supplyc.EntityFrameworkCore
{
    public static class supplycDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<supplycDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<supplycDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
