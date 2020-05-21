using Abp.Application.Services;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Application;
using Service.Products.Model;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ProductCommandService : ApplicationService
    {
        private readonly IRepository<Service.Products.Model.Product> _product;

        private readonly IProductCommandAdapterService _productCommandAdapter;

        public ProductCommandService(IRepository<Product> product, IProductCommandAdapterService productCommandAdapter)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _productCommandAdapter = productCommandAdapter ?? throw new ArgumentNullException(nameof(productCommandAdapter));
        }

        public async System.Threading.Tasks.Task Create(ProductsDto model)
        {
            await _product.InsertAsync(_productCommandAdapter.CreateUpdate(model));
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            await _product.DeleteAsync(id);
        }

        public async System.Threading.Tasks.Task Update(ProductsDto model)
        {
            await _product.UpdateAsync(_productCommandAdapter.CreateUpdate(model));
        }
    }
}
