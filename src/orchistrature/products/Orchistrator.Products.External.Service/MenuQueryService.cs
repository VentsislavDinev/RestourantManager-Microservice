using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;

namespace WiLSoft.Automation.RestourantManager
{
    public class MenuQueryService : ApplicationService, IQuery<MenuListDto, MenuDto>
    {
        public System.Threading.Tasks.Task<MenuDto> Get<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<MenuListDto> GetAll<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
