using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Products.Abstract;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using WiLSoft.Automation.RestourantManager.Model;

namespace WiLSoft.Automation.RestourantManager
{
    public class MenuQueryService : ApplicationService, IMenuQueryService
    {
        private readonly HttpClient _apiClient;

        public MenuQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }


        public async System.Threading.Tasks.Task<MenuDto> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<MenuDto>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<MenuDto>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<MenuDto>>(responseString);
        }
    }
}
