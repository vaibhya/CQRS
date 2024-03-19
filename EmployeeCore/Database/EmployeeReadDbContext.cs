using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCore.Database
{
    public class EmployeeReadDbContext : DbContext
    {
        public EmployeeReadDbContext(DbContextOptions<EmployeeReadDbContext> options): base(options)
        {

        }

        public DbSet<Employee> ReadEmployees {get; set;}
    }
}