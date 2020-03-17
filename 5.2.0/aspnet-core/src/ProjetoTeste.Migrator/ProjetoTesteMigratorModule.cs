using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjetoTeste.Configuration;
using ProjetoTeste.EntityFrameworkCore;
using ProjetoTeste.Migrator.DependencyInjection;

namespace ProjetoTeste.Migrator
{
    [DependsOn(typeof(ProjetoTesteEntityFrameworkModule))]
    public class ProjetoTesteMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ProjetoTesteMigratorModule(ProjetoTesteEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ProjetoTesteMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ProjetoTesteConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjetoTesteMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
