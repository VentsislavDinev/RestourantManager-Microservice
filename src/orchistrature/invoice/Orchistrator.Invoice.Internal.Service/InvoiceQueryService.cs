using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Invoice.Model;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Orchistrator.Invoice.Internal.Service
{
    public class InvoiceQueryService : ApplicationService, IInvoiceQueryService
    {
        private readonly HttpClient _apiClient;

        public InvoiceQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }


        public async System.Threading.Tasks.Task<InvoiceEntity> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<InvoiceEntity>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<InvoiceEntity>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<InvoiceEntity>>(responseString);
        }
    }
}
