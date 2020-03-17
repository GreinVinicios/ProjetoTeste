using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjetoTeste.Authorization;

namespace ProjetoTeste
{
    [DependsOn(
        typeof(ProjetoTesteCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProjetoTesteApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProjetoTesteAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProjetoTesteApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
