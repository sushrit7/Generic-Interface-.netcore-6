using APIRepositoryInterface.Interface;
using APIRepositoryInterface.Models;

namespace APIRepositoryInterface.Service
{
    public class EmployeeService : IGenericService<Employee>
    {

        List<Employee> employees = new List<Employee>();

        public EmployeeService()
        {
            for (int i = 1; i < 5; i++)
            {
                employees.Add(new Employee()
                {
                    id = i,
                    Name = "Employee " + i,
                    ApplyingPosition = "Developer " + i,

                });
            }
        }

        public List<Employee> Delete(int id)
        {
            employees.RemoveAll(x => x.id == id);
            return employees;
        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            var Employee = employees.Where(x => x.id == id)
                .FirstOrDefault();
            return Employee;
        }

        public List<Employee> Insert(Employee item)
        {
            employees.Add(item);
            return employees  ;

        }
    }
}

