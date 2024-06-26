using GestionUsuarioCRUD.Models.Entities;

namespace GestionUsuarioCRUD.Repositories
{
    public interface IEmployeeRepository
    {
        Task AddEmployee(Employee employee);
        Task DeleteEmployee(int id);

    }
}
