using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EmployeeCore.Models;



namespace EmployeeCore.Repository
{
    public interface IEmployeeReadRepository
    {
        public List<Employee> GetALlEmployee(); 
        public Employee GetEmployeeById(int id);  
    }
}