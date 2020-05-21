using System.Threading.Tasks;
using Abp.Application.Services;
using Restourant.Manager.Sessions.Dto;

namespace Restourant.Manager.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
