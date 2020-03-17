using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProjetoTeste.EntityFrameworkCore
{
    public static class ProjetoTesteDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjetoTesteDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjetoTesteDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
