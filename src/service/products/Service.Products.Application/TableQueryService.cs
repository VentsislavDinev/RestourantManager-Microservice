using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Model;

using System.Linq.Dynamic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class TableQueryService : ApplicationService, ITableQueryService
    {
        private readonly IRepository<Service.Products.Model.Table> _product;

        public TableQueryService(IRepository<Table> product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public async System.Threading.Tasks.Task<TableDto> Get(int model)
        {
            return ObjectMapper.Map<TableDto>(await _product.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<TableDto>> GetAll(TableSortDto model)
        {
            var products = await _product.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _product.CountAsync();

            var dtos = ObjectMapper.Map<List<TableDto>>(products);

            return new PagedResultDto<TableDto>(totalCount, dtos);
        }
    }
}
