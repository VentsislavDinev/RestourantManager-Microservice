using System.Threading.Tasks;
using Abp.Application.Services;
using Restourant.Manager.Authorization.Accounts.Dto;

namespace Restourant.Manager.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
