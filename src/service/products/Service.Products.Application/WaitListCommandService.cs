using Abp.Application.Services;
using Abp.Domain.Repositories;

using Domain.Products.Abstract;

using Service.Products.Application.Adapters;
using Service.Products.Model;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class WaitListCommandService : ApplicationService, IWaitListCommandService
    {
        private readonly IWaitListAdapterCommandService _waitListAdapterCommandService;
        private readonly IRepository<WaitList> _waitList;

        public WaitListCommandService(IWaitListAdapterCommandService waitListAdapterCommandService, IRepository<WaitList> waitList)
        {
            _waitListAdapterCommandService = waitListAdapterCommandService ?? throw new ArgumentNullException(nameof(waitListAdapterCommandService));
            _waitList = waitList ?? throw new ArgumentNullException(nameof(waitList));
        }

        public async System.Threading.Tasks.Task Create(WaitListDto model)
        {
            await _waitList.InsertAsync(_waitListAdapterCommandService.CreateUpdate(model));
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            await _waitList.DeleteAsync(id);
        }

        public async System.Threading.Tasks.Task Update(WaitListDto model)
        {
            await _waitList.UpdateAsync(_waitListAdapterCommandService.CreateUpdate(model));
        }
    }
}
