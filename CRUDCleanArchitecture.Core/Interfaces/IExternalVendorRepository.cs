using CRUDCleanArchitecture.Core.Models;

namespace CRUDCleanArchitecture.Core.Interfaces
{
    public interface IExternalVendorRepository
    {
        Task<CoindeskData> GetData();
    }
}
