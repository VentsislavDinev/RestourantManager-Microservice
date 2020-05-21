using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Model;

using System.Linq.Dynamic.Core;
using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;
using System.Linq;

namespace WiLSoft.Automation.RestourantManager
{
    public class ProductQueryService : ApplicationService, IProductQueryService
    {
        private readonly IRepository<Service.Products.Model.Product> _product;

        public ProductQueryService(IRepository<Product> product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public async System.Threading.Tasks.Task<ProductsDto> Get(int model)
        {
            return ObjectMapper.Map<ProductsDto>(await _product.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<ProductsDto>> GetAll(ProductSortDto model)
        {
            var products = await _product.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _product.CountAsync();

            var dtos = ObjectMapper.Map<List<ProductsDto>>(products);

            return new PagedResultDto<ProductsDto>(totalCount, dtos);
        }
    }
}
