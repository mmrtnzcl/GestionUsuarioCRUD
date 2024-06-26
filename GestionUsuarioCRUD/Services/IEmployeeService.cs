using GestionUsuarioCRUD.Models.Entities;

namespace GestionUsuarioCRUD.Services
{
    public interface IEmployeeService
    {

        Task AddEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
