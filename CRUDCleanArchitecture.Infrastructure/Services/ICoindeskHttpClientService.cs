using CRUDCleanArchitecture.Core.Models;

namespace CRUDCleanArchitecture.Infrastructure.Services
{
    public interface ICoindeskHttpClientService
    {
        Task<CoindeskData> GetData();
    }
}