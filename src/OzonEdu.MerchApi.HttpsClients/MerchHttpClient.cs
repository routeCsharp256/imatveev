using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OzonEdu.MerchApi.HttpsClients.Interfaces;

namespace OzonEdu.MerchApi.HttpsClients
{
    public class MerchHttpClient : IMerchHttpClient
    {
        private readonly HttpClient _httpClient;

        public MerchHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task V1GiveMerch(long employeeId, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync($"v1/api/giveMerchByEmployeeId{employeeId}", token);
            throw new NotImplementedException();
        }
        
        public async Task<bool> V1CheckMerch(long employeeId, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync("v1/api/checkMerchByEmployeeId{employeeId}", token);
            throw new NotImplementedException();
        }
    }
}