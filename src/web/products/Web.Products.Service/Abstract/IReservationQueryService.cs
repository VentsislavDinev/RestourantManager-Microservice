using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IReservationQueryService : IApplicationService
    {
        Task<ReservationViewModel> Get(int model);
        Task<PagedResultDto<ReservationViewModel>> GetAll();
    }
}