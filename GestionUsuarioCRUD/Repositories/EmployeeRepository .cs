using GestionUsuarioCRUD.Models.Entities;

namespace GestionUsuarioCRUD.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteEmployee(int id)
        {
            var empoloyee = await _context.Employees.FindAsync(id);
            if(empoloyee != null)
            {
                _context.Employees.Remove(empoloyee);
                await _context.SaveChangesAsync();  
            }
        }
    }
}
