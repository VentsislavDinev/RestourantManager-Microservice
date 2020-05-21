using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ProductCommandService : ApplicationService,  ICommand<ProductsDto>
    {
        public System.Threading.Tasks.Task<ProductsDto> Create<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<ProductsDto> Delete<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<ProductsDto> Update<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
