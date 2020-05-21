using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class KitchenCommandService : ApplicationService, ICommand<KitchenDto>
    {
        public System.Threading.Tasks.Task<KitchenDto> Create<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<KitchenDto> Delete<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<KitchenDto> Update<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
