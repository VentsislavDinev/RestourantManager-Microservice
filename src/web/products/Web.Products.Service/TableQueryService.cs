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
    public class TableQueryService : ApplicationService, ITableQueryService
    {

        private readonly HttpClient _apiClient;

        public TableQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async System.Threading.Tasks.Task<TableViewModel> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<TableViewModel>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<TableViewModel>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<TableViewModel>>(responseString);
        }
    }
}
