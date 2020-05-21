using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Products.Abstract;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ReservationQueryService : ApplicationService, IReservationQueryService
    {
        private readonly HttpClient _apiClient;

        public ReservationQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }


        public async System.Threading.Tasks.Task<ReservationDto> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ReservationDto>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<ReservationDto>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<ReservationDto>>(responseString);
        }
    }
}
