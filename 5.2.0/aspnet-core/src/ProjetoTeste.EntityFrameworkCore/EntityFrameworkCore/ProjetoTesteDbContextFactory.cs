using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProjetoTeste.Configuration;
using ProjetoTeste.Web;

namespace ProjetoTeste.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProjetoTesteDbContextFactory : IDesignTimeDbContextFactory<ProjetoTesteDbContext>
    {
        public ProjetoTesteDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProjetoTesteDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProjetoTesteDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProjetoTesteConsts.ConnectionStringName));

            return new ProjetoTesteDbContext(builder.Options);
        }
    }
}
