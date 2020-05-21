using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Products.Abstract;

using Newtonsoft.Json;

using Orchistrator.Products.Internal.Service.Senders;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;
using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class KitchenQueryService : ApplicationService, IKitchenQueryService
    {
        private readonly HttpClient _apiClient;

        public KitchenQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async System.Threading.Tasks.Task<KitchenDto> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<KitchenDto>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<KitchenDto>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<KitchenDto>>(responseString);
        }
    }
}
