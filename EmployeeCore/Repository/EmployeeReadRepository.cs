using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCore.Database;
using EmployeeCore.Models;



namespace EmployeeCore.Repository
{
    public class EmployeeReadRepository : IEmployeeReadRepository
    {
        private EmployeeReadDbContext _dbReadContext;

        public EmployeeReadRepository(EmployeeReadDbContext dbReadContext)
        {
            _dbReadContext = dbReadContext;
        }
        public List<Employee> GetALlEmployee()
        {
            return _dbReadContext.ReadEmployees.ToList();
        
        }
        public Employee GetEmployeeById(int id)
        {
            return _dbReadContext.ReadEmployees.FirstOrDefault(emp => emp.Id == id);
        }
    }
}