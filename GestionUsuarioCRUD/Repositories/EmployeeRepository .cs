﻿using GestionUsuarioCRUD.Models.Entities;
using Microsoft.EntityFrameworkCore;

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
            var employee = await _context.Employees.FindAsync(id);
            if(employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();  
            }
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            var employeeList = new List<Employee>();
            return employeeList = await _context.Employees.ToListAsync();

        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if(employee != null)
                return employee;
            return null;
        }
    }
}
