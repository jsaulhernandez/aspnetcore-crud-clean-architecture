using CRUDCleanArchitecture.Core.Interfaces;
using CRUDCleanArchitecture.Core.Models;
using MediatR;

namespace CRUDCleanArchitecture.Application.Queries
{

    public record GetCoindeskDataQuery() : IRequest<CoindeskData>;

    public class GetCoindeskDataQueryHandle(IExternalVendorRepository externalVendorRepository)
        : IRequestHandler<GetCoindeskDataQuery, CoindeskData>
    {
        public async Task<CoindeskData> Handle(GetCoindeskDataQuery request, CancellationToken cancellationToken)
        {
            return await externalVendorRepository.GetData();
        }
    }
}
