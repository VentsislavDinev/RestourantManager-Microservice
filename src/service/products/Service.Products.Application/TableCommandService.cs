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
    public class TableCommandService : ApplicationService, ITableCommandService
    {
        private readonly ITableAdapterCommandService _tableAdapterCommandService;
        private readonly IRepository<Service.Products.Model.Table> _table;

        public TableCommandService(ITableAdapterCommandService tableAdapterCommandService, IRepository<Table> table)
        {
            _tableAdapterCommandService = tableAdapterCommandService ?? throw new ArgumentNullException(nameof(tableAdapterCommandService));
            _table = table ?? throw new ArgumentNullException(nameof(table));
        }

        public async System.Threading.Tasks.Task Create(TableDto model)
        {
            await _table.InsertAsync(_tableAdapterCommandService.CreateUpdate(model));
        }

        public async System.Threading.Tasks.Task Delete(int id)
        {
            await _table.DeleteAsync(id);
        }

        public async System.Threading.Tasks.Task Update(TableDto model)
        {
            await _table.InsertAsync(_tableAdapterCommandService.CreateUpdate(model));
        }
    }
}
