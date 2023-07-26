using System.Threading.Tasks;
using Abp.Application.Services;
using PayMetrix.Account.Dto;
using PayMetrix.Authorization.Accounts.Dto;

namespace PayMetrix.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
        Task<ImpersonateOutput> Impersonate(ImpersonateInput input);

        Task<ImpersonateOutput> BackToImpersonator();
    }
}
