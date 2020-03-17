using Abp.Application.Services;
using ProjetoTeste.MultiTenancy.Dto;

namespace ProjetoTeste.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

