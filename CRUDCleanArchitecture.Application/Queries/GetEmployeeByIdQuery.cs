using CRUDCleanArchitecture.Core.Entities;
using CRUDCleanArchitecture.Core.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCleanArchitecture.Application.Queries
{
    public record GetEmployeeByIdQuery(Guid id) : IRequest<EmployeeEntity>;

    public class GetEmployeeByIdQueryHandle(IEmployeeRepository employeeRepository)
        : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByIdAsync(request.id);
        }
    }
}
