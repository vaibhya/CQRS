using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCore.Database
{
    public class EmployeeWriteDbContext : DbContext
    {
        public EmployeeWriteDbContext(DbContextOptions<EmployeeWriteDbContext> options): base(options)
        {

        }

        public DbSet<Employee> WriteEmployees {get; set;}   
    }
}