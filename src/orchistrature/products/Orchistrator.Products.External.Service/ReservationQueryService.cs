using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ReservationQueryService : ApplicationService, IQuery<ReservationListDto, ReservationDto>
    {
        public System.Threading.Tasks.Task<ReservationDto> Get<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<ReservationListDto> GetAll<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
