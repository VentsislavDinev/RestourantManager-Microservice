﻿using Abp.Application.Services;

using Domain.Products.Abstract;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public class KitchenCommandService : ApplicationService, IKitchenCommandService
    {
        private readonly HttpClient _apiClient;

        public KitchenCommandService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async Task Create(KitchenViewModel model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);

            response.EnsureSuccessStatusCode();
        }

        public async Task Update(KitchenViewModel model)
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
