using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TrainCore.EntityFrameworkCore
{
    public static class TrainCoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TrainCoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TrainCoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
