using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcRepositoryPattern.Models
{
    
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { id = 1, Name = "Mary", Department = "HR", Email = "mary@opti.com"},
                new Employee() { id = 2, Name = "Jerry", Department = "IT", Email = "Jerry@opti.com"},
                new Employee() { id = 3, Name = "Harry", Department = "Dev", Email = "Harry@opti.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.id == id);
        }
    }
}
