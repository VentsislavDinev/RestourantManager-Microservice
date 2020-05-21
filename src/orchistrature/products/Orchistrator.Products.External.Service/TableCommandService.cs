using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class TableCommandService : ApplicationService, ICommand<TableDto>
    {
        public System.Threading.Tasks.Task<TableDto> Create<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<TableDto> Delete<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<TableDto> Update<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
