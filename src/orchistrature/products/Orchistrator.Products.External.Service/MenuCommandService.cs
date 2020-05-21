using Abp.Application.Services;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;


namespace WiLSoft.Automation.RestourantManager
{
    public class MenuCommandService : ApplicationService, ICommand<MenuDto>
    {
        public System.Threading.Tasks.Task<MenuDto> Create<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<MenuDto> Delete<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<MenuDto> Update<Model>(Model model) where Model : class
        {
            throw new NotImplementedException();
        }
    }
}
