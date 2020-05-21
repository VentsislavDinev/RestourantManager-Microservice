using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Employee.Model;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Orchistrator.Employee.Internal.Service
{
    public class EmployeeQueryService : ApplicationService, IEmployeeQueryService
    {
        private readonly HttpClient _apiClient;

        public EmployeeQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }


        public async System.Threading.Tasks.Task<EmployeeEntity> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<EmployeeEntity>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<EmployeeEntity>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<EmployeeEntity>>(responseString);
        }
    }
}
