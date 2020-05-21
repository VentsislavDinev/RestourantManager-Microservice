using Abp.Application.Services;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Application;
using Service.Products.Model;

using System;
using System.Collections.Generic;
using System.Text;


namespace WiLSoft.Automation.RestourantManager
{
    public class MenuCommandService : ApplicationService, IMenuCommandService
    {
        private readonly IRepository<Service.Products.Model.Menu> _menu;

        private readonly IMenuAdapterCommandService _menuAdapterCommand;

        public MenuCommandService(IRepository<Menu> menu, IMenuAdapterCommandService menuAdapterCommand)
        {
            _menu = menu ?? throw new ArgumentNullException(nameof(menu));
            _menuAdapterCommand = menuAdapterCommand ?? throw new ArgumentNullException(nameof(menuAdapterCommand));
        }

        public async System.Threading.Tasks.Task Create(MenuDto model)
        {
            await _menu.InsertAsync(_menuAdapterCommand.CreateUpdate(model));
        }

        public async System.Threading.Tasks.Task Delete(int model)
        {
            await _menu.DeleteAsync(model);
        }

        public async System.Threading.Tasks.Task<MenuDto> Update(MenuDto model)
        {
            return ObjectMapper.Map<MenuDto>(await _menu.UpdateAsync(_menuAdapterCommand.CreateUpdate(model)));
        }
    }
}
