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
    public record GetAllEmployeesQuery(): IRequest<IEnumerable<EmployeeEntity>>;
    public class GetAllEmployeesQueryHandler(IEmployeeRepository employeeRepository)
        :IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeesAsync();
        }
    }
}
