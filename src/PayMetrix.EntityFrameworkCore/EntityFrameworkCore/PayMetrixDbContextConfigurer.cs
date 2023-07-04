using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PayMetrix.EntityFrameworkCore
{
    public static class PayMetrixDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PayMetrixDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PayMetrixDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
