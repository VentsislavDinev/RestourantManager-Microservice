using Abp.Application.Services;

using Domain.Products.Abstract;

using Newtonsoft.Json;

using Orchistrator.Products.Internal.Service.Senders;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class ProductCommandService : ApplicationService, IProductCommandService
    {
        private readonly HttpClient _apiClient;

        private readonly IProductSender _kitchenSender;

        public ProductCommandService(HttpClient apiClient, IProductSender kitchenSender)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            _kitchenSender = kitchenSender ?? throw new ArgumentNullException(nameof(kitchenSender));
        }

        public async Task Create(ProductsDto model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);
            _kitchenSender.SendCustomer(model);
            response.EnsureSuccessStatusCode();
        }

        public async Task Update(ProductsDto model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);
            _kitchenSender.SendCustomer(model);
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
