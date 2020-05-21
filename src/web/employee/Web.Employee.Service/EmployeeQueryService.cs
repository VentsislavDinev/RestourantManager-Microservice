using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using Web.Employee.Service.ViewModel;

namespace Web.Employee.Service
{
    public class EmployeeQueryService : ApplicationService, IEmployeeQueryService
    {

        private readonly HttpClient _apiClient;

        public EmployeeQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async System.Threading.Tasks.Task<EmployeeViewModel> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<EmployeeViewModel>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<EmployeeViewModel>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<EmployeeViewModel>>(responseString);
        }
    }
}
