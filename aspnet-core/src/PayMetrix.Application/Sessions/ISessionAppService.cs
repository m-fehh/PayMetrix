using System.Threading.Tasks;
using Abp.Application.Services;
using PayMetrix.Sessions.Dto;

namespace PayMetrix.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
