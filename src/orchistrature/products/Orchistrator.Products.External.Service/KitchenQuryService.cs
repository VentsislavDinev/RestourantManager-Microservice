using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class KitchenQueryService : ApplicationService, IQuery<KitchenListDto, KitchenDto>
    {
        public System.Threading.Tasks.Task<KitchenDto> Get<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<KitchenListDto> GetAll<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
