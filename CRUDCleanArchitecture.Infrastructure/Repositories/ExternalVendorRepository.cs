using CRUDCleanArchitecture.Core.Interfaces;
using CRUDCleanArchitecture.Core.Models;
using CRUDCleanArchitecture.Infrastructure.Services;

namespace CRUDCleanArchitecture.Infrastructure.Repositories
{
    public class ExternalVendorRepository(ICoindeskHttpClientService coindeskHttpClientService)
        : IExternalVendorRepository
    {
        public async Task<CoindeskData> GetData()
        {
            return await coindeskHttpClientService.GetData();
        }
    }
}
