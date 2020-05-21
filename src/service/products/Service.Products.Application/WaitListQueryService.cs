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
    public class WaitListQueryService : ApplicationService, IWaitListQueryService
    {
        private readonly IRepository<WaitList> _waitList;

        public WaitListQueryService(IRepository<WaitList> waitList)
        {
            _waitList = waitList ?? throw new ArgumentNullException(nameof(waitList));
        }

        public async System.Threading.Tasks.Task<WaitListDto> Get(int model)
        {
            return ObjectMapper.Map<WaitListDto>(await _waitList.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<WaitListDto>> GetAll(SortWaitListDto model)
        {
            var products = await _waitList.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _waitList.CountAsync();

            var dtos = ObjectMapper.Map<List<WaitListDto>>(products);

            return new PagedResultDto<WaitListDto>(totalCount, dtos);
        }
    }
}
