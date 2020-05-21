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
    public class ReservationQueryService : ApplicationService, IReservationQueryService
    {
        private readonly IRepository<Service.Products.Model.Reservation> _product;

        public ReservationQueryService(IRepository<Reservation> product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public async System.Threading.Tasks.Task<ReservationDto> Get(int model)
        {

            return ObjectMapper.Map<ReservationDto>(await _product.GetAsync(model));
        }

        public async System.Threading.Tasks.Task<PagedResultDto<ReservationDto>> GetAll(ReservationSortDto model)
        {
            var products = await _product.GetAllList().AsQueryable()
               .OrderBy(model.Sorting ?? "Title")
               .Skip(model.SkipCount)
               .Take(model.MaxResultCount)
               .ToDynamicListAsync();

            var totalCount = await _product.CountAsync();

            var dtos = ObjectMapper.Map<List<ReservationDto>>(products);

            return new PagedResultDto<ReservationDto>(totalCount, dtos);
        }
    }
}
