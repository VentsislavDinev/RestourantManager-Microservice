using Abp.Application.Services;

using Domain.Employee.Model;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Orchistrator.Employee.Internal.Service
{
    public class EmployeeService : ApplicationService, IEmployeeService
    {

        private readonly HttpClient _apiClient;
        private readonly IEmployeeSender _employeeSender;

        public EmployeeService(HttpClient apiClient, IEmployeeSender employeeSender)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            _employeeSender = employeeSender ?? throw new ArgumentNullException(nameof(employeeSender));
        }

        public async Task Create(EmployeeEntity model)
        {


            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);
            _employeeSender.SendCustomer(model);
            response.EnsureSuccessStatusCode();

        }

        public async Task Update(EmployeeEntity model)
        {


            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);

            _employeeSender.SendCustomer(model);
            response.EnsureSuccessStatusCode();

        }

        public async Task Delete(int id)
        {


            var basketContent = new StringContent(JsonConvert.SerializeObject(id), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);

            response.EnsureSuccessStatusCode();

        }
    }
}
