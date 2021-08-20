using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _emloyeeList;
        public MockEmployeeRepository()
        {
            _emloyeeList = new List<Employee>()
            {
                new Employee(){ Id=1,Name="Mary",Department="HR",Email="mary@pragim.com"},
                new Employee(){ Id=2,Name="John",Department="IT",Email="mwt@pragim.com"},
                new Employee(){ Id=3,Name="Sam",Department="IT",Email="wtf@pragim.com"}
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _emloyeeList.FirstOrDefault(e => e.Id == Id);
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _emloyeeList;
        }
    }
}
