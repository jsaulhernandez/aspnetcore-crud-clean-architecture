using CRUDCleanArchitecture.Core.Models;
using System.Net.Http.Json;

namespace CRUDCleanArchitecture.Infrastructure.Services
{
    public class CoindeskHttpClientService(HttpClient httpClient) : ICoindeskHttpClientService
    {
        public async Task<CoindeskData> GetData()
        {
            return await httpClient.GetFromJsonAsync<CoindeskData>("bpi/currentprice.json");
        }
    }
}
