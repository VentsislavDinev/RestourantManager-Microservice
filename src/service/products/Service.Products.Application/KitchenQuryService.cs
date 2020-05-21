using Abp.Application.Services;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Linq.Dynamic.Core;
using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;
using Abp.Application.Services.Dto;

namespace WiLSoft.Automation.RestourantManager
{
    public class KitchenQueryService : ApplicationService, IKitchenQueryService
    {
        private readonly IRepository<Service.Products.Model.Kitchen> _kitchen;

        public KitchenQueryService(IRepository<Kitchen> kitchen)
        {
            _kitchen = kitchen ?? throw new ArgumentNullException(nameof(kitchen));
        }

        public async System.Threading.Tasks.Task<KitchenDto> Get(int model)
        {
            return ObjectMapper.Map<KitchenDto>(await _kitchen.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<KitchenDto>> GetAll(KitchenSortDto model)
        {
            var products = await _kitchen.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _kitchen.CountAsync();

            var dtos = ObjectMapper.Map<List<KitchenDto>>(products);

            return new PagedResultDto<KitchenDto>(totalCount, dtos);
        }
    }
}
