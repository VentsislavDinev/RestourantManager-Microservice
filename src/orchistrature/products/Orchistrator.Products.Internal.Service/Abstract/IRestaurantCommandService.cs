using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IRestaurantCommandService : IApplicationService
    {
        Task Create(ReservationDto model);
        Task Delete(int id);
        Task Update(ReservationDto model);
    }
}