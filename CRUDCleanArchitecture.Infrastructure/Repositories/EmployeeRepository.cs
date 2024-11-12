using CRUDCleanArchitecture.Core.Entities;
using CRUDCleanArchitecture.Core.Interfaces;
using CRUDCleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCleanArchitecture.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDBContext dBContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployeesAsync() => await dBContext.Employees.ToListAsync();
        public async Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id) => await dBContext.Employees.FirstOrDefaultAsync(e => e.Id == id);

        public async Task<EmployeeEntity> AddEmployeeAsync(EmployeeEntity employee)
        {
            employee.Id = Guid.NewGuid();
            dBContext.Employees.Add(employee);

            await dBContext.SaveChangesAsync();

            return employee;
        }

        public async Task<EmployeeEntity> UpdateEmployeeAsync(Guid id, EmployeeEntity employee)
        {
            var gettingEmployee = await dBContext.Employees.FirstOrDefaultAsync(e => e.Id == id);

            if (gettingEmployee is not null)
            {
                gettingEmployee.Name = employee.Name;
                gettingEmployee.Phone = employee.Phone;
                gettingEmployee.Email = employee.Email;
                gettingEmployee.Salary = employee.Salary;

                await dBContext.SaveChangesAsync();

                return gettingEmployee;
            }

            return employee;
        }

        public async Task<bool> DeleteEmployeeAsync(Guid id)
        {
            var gettingEmployee = await dBContext.Employees.FirstOrDefaultAsync(e => e.Id == id);

            if(gettingEmployee is not null) 
            {
                dBContext.Employees.Remove(gettingEmployee);

                return await dBContext.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
