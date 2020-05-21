using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ReservationCommandService : ApplicationService, ICommand<ReservationDto>
    {
        public System.Threading.Tasks.Task<ReservationDto> Create<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<ReservationDto> Delete<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<ReservationDto> Update<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
