using GestionUsuarioCRUD.Models.Entities;
using GestionUsuarioCRUD.Models.ModelsDTO;
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

        public async Task DeleteEmployee(int id)
        {
            await _employeeRepository.DeleteEmployee(id);
        }

        public Task<List<Employee>> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetEmployeeById(id);
        }

        public async Task<EmployeeSalaryDTO> GetSalaryEmployeeById(int id)
        {
            return await _employeeRepository.GetSalaryEmployeeById(id);
        }

        public async Task<Employee> UpdateEmployee(Employee existingEm, Employee newEmployee)
        {
            return await _employeeRepository.UpdateEmployee(existingEm, newEmployee);
        }

        public async Task<bool> UpdateLastSalary(Employee employee, decimal newSalary)
        {
            try
            {
               employee.UltimoSalarioTotal = newSalary;
               await _employeeRepository.UpdateLastSalary(employee);
               return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
