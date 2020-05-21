using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class WaitListCommandService : ApplicationService, ICommand<WaitListDto>
    {
        public System.Threading.Tasks.Task<WaitListDto> Create<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<WaitListDto> Delete<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<WaitListDto> Update<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
