using Abp.Application.Services.Dto;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IReservationQueryService
    {
        Task<ReservationDto> Get(int model);
        Task<PagedResultDto<ReservationDto>> GetAll(ReservationSortDto model);
    }
}