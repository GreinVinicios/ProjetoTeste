using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProjetoTeste.Controllers
{
    public abstract class ProjetoTesteControllerBase: AbpController
    {
        protected ProjetoTesteControllerBase()
        {
            LocalizationSourceName = ProjetoTesteConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
