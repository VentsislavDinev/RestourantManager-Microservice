using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using Web.Invoice.Service.ViewModel;

namespace Web.Invoice.Service
{
    public class InvoiceQueryService : ApplicationService, IInvoiceQueryService
    {

        private readonly HttpClient _apiClient;

        public InvoiceQueryService(HttpClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async System.Threading.Tasks.Task<InvoiceViewModel> Get(int model)
        {
            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<InvoiceViewModel>(responseString);
        }

        public async System.Threading.Tasks.Task<PagedResultDto<InvoiceViewModel>> GetAll()
        {

            var response = await _apiClient.GetAsync("");
            var responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PagedResultDto<InvoiceViewModel>>(responseString);
        }
    }
}
