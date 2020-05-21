using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IReservationCommandService : IApplicationService
    {
        Task Create(ReservationViewModel model);
        Task Delete(int model);
        Task Update(ReservationViewModel model);
    }
}