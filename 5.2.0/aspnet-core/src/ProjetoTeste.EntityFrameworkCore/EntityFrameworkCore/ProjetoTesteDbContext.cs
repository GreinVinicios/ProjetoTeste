using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProjetoTeste.Authorization.Roles;
using ProjetoTeste.Authorization.Users;
using ProjetoTeste.MultiTenancy;

namespace ProjetoTeste.EntityFrameworkCore
{
    public class ProjetoTesteDbContext : AbpZeroDbContext<Tenant, Role, User, ProjetoTesteDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProjetoTesteDbContext(DbContextOptions<ProjetoTesteDbContext> options)
            : base(options)
        {
        }
    }
}
