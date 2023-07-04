using Abp.Application.Services;
using PayMetrix.MultiTenancy.Dto;

namespace PayMetrix.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

