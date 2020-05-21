using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ProductQueryService : ApplicationService, IQuery<ProductListDto, ProductsDto>
    {
        public System.Threading.Tasks.Task<ProductsDto> Get<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<ProductListDto> GetAll<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
