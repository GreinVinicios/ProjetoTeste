using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProjetoTeste.Configuration;

namespace ProjetoTeste.Web.Host.Startup
{
    [DependsOn(
       typeof(ProjetoTesteWebCoreModule))]
    public class ProjetoTesteWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProjetoTesteWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProjetoTesteWebHostModule).GetAssembly());
        }
    }
}
