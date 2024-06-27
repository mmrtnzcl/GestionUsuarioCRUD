using GestionUsuarioCRUD.Models.Entities;
using GestionUsuarioCRUD.Models.ModelsDTO;

namespace GestionUsuarioCRUD.Services
{
    public interface IEmployeeService
    {
        Task AddEmployee(Employee employee);
        Task DeleteEmployee(int id);
        Task<Employee> GetEmployeeById(int id);
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> UpdateEmployee(Employee existingEm, Employee newEmployee);
        Task<EmployeeSalaryDTO> GetSalaryEmployeeById(int id);
    }
}
