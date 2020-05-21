using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

using WiLSoft.Automation.RestourantManager;
using WiLSoft.Automation.RestourantManager.Module;

namespace Website.Products.Web.Controllers
{
    public class ResservationController : AbpController
    {
        private readonly IReservationCommandService _reservation;
        private readonly IReservationQueryService _reservationQueryService;

        public ResservationController(IReservationCommandService reservation, IReservationQueryService reservationQueryService)
        {
            _reservation = reservation ?? throw new ArgumentNullException(nameof(reservation));
            _reservationQueryService = reservationQueryService ?? throw new ArgumentNullException(nameof(reservationQueryService));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _reservationQueryService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _reservationQueryService.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _reservationQueryService.Get(id));
        }

        public async Task<IActionResult> Update(ReservationViewModel model)
        {
            await _reservation.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _reservationQueryService.Get(id));
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _reservation.Delete(id);
            return Redirect("/");
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(ReservationViewModel model)
        {
            await _reservation.Create(model);
            return Redirect("/");
        }
    }
}
