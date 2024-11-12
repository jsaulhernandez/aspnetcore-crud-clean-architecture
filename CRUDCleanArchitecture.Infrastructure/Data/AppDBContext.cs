using CRUDCleanArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCleanArchitecture.Infrastructure.Data
{
    public class AppDBContext(DbContextOptions<AppDBContext> options):DbContext(options)
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
