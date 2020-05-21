using Abp.Application.Services;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Web.Invoice.Service.ViewModel;

namespace Web.Invoice.Service
{
    public class InvoiceService : ApplicationService, IInvoiceService
    {

        private readonly HttpClient _apiClient;

        public InvoiceService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async Task Create(InvoiceViewModel model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);

            response.EnsureSuccessStatusCode();
        }

        public async Task Update(InvoiceViewModel model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);

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
