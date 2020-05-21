using Abp.Application.Services;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Application;
using Service.Products.Model;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ReservationCommandService : ApplicationService, IReservationCommandService
    {
        private readonly IRepository<Reservation> _reservation;
        private readonly IReservationCommandAdapterService _reservationCommandAdapterService;
        public async System.Threading.Tasks.Task Create(ReservationDto model)
        {
            await _reservation.InsertAsync(_reservationCommandAdapterService.CreateUpdate(model));
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            await _reservation.DeleteAsync(id);
        }

        public async System.Threading.Tasks.Task Update(ReservationDto model)
        {
            await _reservation.UpdateAsync(_reservationCommandAdapterService.CreateUpdate(model));
        }
    }
}
