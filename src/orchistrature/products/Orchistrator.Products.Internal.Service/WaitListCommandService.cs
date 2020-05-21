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
    public class WaitListCommandService : ApplicationService, IWaitListCommandService
    {
        private readonly HttpClient _apiClient;

        private readonly IWaitListSender _kitchenSender;

        public WaitListCommandService(HttpClient apiClient, IWaitListSender kitchenSender)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            _kitchenSender = kitchenSender ?? throw new ArgumentNullException(nameof(kitchenSender));
        }

        public async Task Create(WaitListDto model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);
            _kitchenSender.SendWaitList(model); 
            response.EnsureSuccessStatusCode();
        }

        public async Task Update(WaitListDto model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);

            _kitchenSender.SendWaitList(model);
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
