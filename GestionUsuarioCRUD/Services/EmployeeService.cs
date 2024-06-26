using GestionUsuarioCRUD.Models.Entities;
using GestionUsuarioCRUD.Repositories;

namespace GestionUsuarioCRUD.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _employeeRepository.AddEmployee(employee);
        }
    }
}
