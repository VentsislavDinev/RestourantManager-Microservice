using Abp.Application.Services;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Model;

using System.Linq.Dynamic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using Abp.Application.Services.Dto;

namespace WiLSoft.Automation.RestourantManager
{
    public class MenuQueryService : ApplicationService, IMenuQueryService
    {
        private readonly IRepository<Service.Products.Model.Menu> _kitchen;

        public MenuQueryService(IRepository<Menu> kitchen)
        {
            _kitchen = kitchen ?? throw new ArgumentNullException(nameof(kitchen));
        }

        public async System.Threading.Tasks.Task<MenuDto> Get(int model)
        {
            return ObjectMapper.Map<MenuDto>(await _kitchen.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<MenuDto>> GetAll(MenuSortDto model)
        {
            var products = await _kitchen.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _kitchen.CountAsync();

            var dtos = ObjectMapper.Map<List<MenuDto>>(products);

            return new PagedResultDto<MenuDto>(totalCount, dtos);
        }
    }
}
