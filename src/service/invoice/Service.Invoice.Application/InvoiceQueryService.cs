using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;

using Domain.Invoice.Model;

using System.Linq.Dynamic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Invoice.Application
{
    public class InvoiceQueryService : ApplicationService, IInvoiceQueryService
    {
        private readonly IRepository<Model.Invoice> _waitList;

        public InvoiceQueryService(IRepository<Model.Invoice> waitList)
        {
            _waitList = waitList ?? throw new ArgumentNullException(nameof(waitList));
        }

        public async System.Threading.Tasks.Task<InvoiceEntity> Get(int model)
        {
            return ObjectMapper.Map<InvoiceEntity>(await _waitList.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<InvoiceEntity>> GetAll(InvoiceSortDto model)
        {
            var products = await _waitList.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _waitList.CountAsync();

            var dtos = ObjectMapper.Map<List<InvoiceEntity>>(products);

            return new PagedResultDto<InvoiceEntity>(totalCount, dtos);
        }
    }
}
