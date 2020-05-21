using Abp.Application.Services;

using Domain.Invoice.Model;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Orchistrator.Invoice.Internal.Service
{
    public class InvoiceCommandService : ApplicationService, IInvoiceCommandService
    {

        private readonly HttpClient _apiClient;
        private readonly IInvoiceSender _invoiceSender;

        public InvoiceCommandService(HttpClient apiClient, IInvoiceSender invoiceSender)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
            _invoiceSender = invoiceSender ?? throw new ArgumentNullException(nameof(invoiceSender));
        }

        public async Task Create(InvoiceEntity model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);
            _invoiceSender.SendWaitList(model);

            response.EnsureSuccessStatusCode();
        }

        public async Task Update(InvoiceEntity model)
        {
            var basketContent = new StringContent(JsonConvert.SerializeObject(model), System.Text.Encoding.UTF8, "application/json");

            var response = await _apiClient.PostAsync("", basketContent);
            _invoiceSender.SendWaitList(model);

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
