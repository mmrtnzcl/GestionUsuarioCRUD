﻿using GestionUsuarioCRUD.Models.Entities;
using GestionUsuarioCRUD.Models.ModelsDTO;
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

        public async Task<EmployeeSalaryDTO> GetSalaryEmployeeById(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
                return null;
            return new EmployeeSalaryDTO { Nombre = employee.Nombre, SalarioEmpleado = employee.GetSalario() };
        }

        public async Task<Employee> UpdateEmployee(Employee existingEm, Employee newEmployee)
        {
            existingEm.Nombre = newEmployee.Nombre;
            existingEm.TipoEmpleado = newEmployee.TipoEmpleado;
            existingEm.SalarioBase = newEmployee.SalarioBase;
            existingEm.PrecioHora = newEmployee.PrecioHora.HasValue ? newEmployee.PrecioHora : existingEm.PrecioHora;
            existingEm.Bonificacion = newEmployee.Bonificacion.HasValue ? newEmployee.Bonificacion : existingEm.Bonificacion;
            existingEm.HorasTrabajadas = newEmployee.HorasTrabajadas.HasValue ? newEmployee.HorasTrabajadas : existingEm.HorasTrabajadas;
            existingEm.UltimoSalarioTotal = newEmployee.UltimoSalarioTotal;
            await _context.SaveChangesAsync();

            return newEmployee;
        }

        public async Task UpdateLastSalary(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
