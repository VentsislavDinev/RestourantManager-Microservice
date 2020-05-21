using Abp.Application.Services;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;
using Service.Products.Model;
using Service.Products.Application;

namespace WiLSoft.Automation.RestourantManager
{
    public class KitchenCommandService : ApplicationService, IKitchenCommandService
    {
        private readonly IRepository<Service.Products.Model.Kitchen> _kitchen;
        private readonly IKitchenAdapterCommandService _kitchenAdapter;

        public async System.Threading.Tasks.Task Create(KitchenDto model)
        {
            await _kitchen.InsertAsync(_kitchenAdapter.CreateUpdate(model));
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            await _kitchen.DeleteAsync(id);
        }

        public async System.Threading.Tasks.Task<KitchenDto> Update(KitchenDto model)
        {
            return ObjectMapper.Map<KitchenDto>(await _kitchen.UpdateAsync(_kitchenAdapter.CreateUpdate(model)));
        }
    }
}
