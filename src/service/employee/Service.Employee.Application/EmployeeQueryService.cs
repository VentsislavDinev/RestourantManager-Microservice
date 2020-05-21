using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;

using System.Linq.Dynamic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Employee.Model;

namespace Service.Employee.Application
{
    public class EmployeeQueryService : ApplicationService, IEmployeeQueryService
    {

        private readonly IRepository<Model.Employee> _waitList;

        public EmployeeQueryService(IRepository<Model.Employee> waitList)
        {
            _waitList = waitList ?? throw new ArgumentNullException(nameof(waitList));
        }

        public async System.Threading.Tasks.Task<EmployeeEntity> Get(int model)
        {
            return ObjectMapper.Map<EmployeeEntity>(await _waitList.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<EmployeeEntity>> GetAll(EmployeeSortDto model)
        {
            var products = await _waitList.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _waitList.CountAsync();

            var dtos = ObjectMapper.Map<List<EmployeeEntity>>(products);

            return new PagedResultDto<EmployeeEntity>(totalCount, dtos);
        }
    }
}
