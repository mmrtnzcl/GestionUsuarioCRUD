using GestionUsuarioCRUD.Models.Entities;
using GestionUsuarioCRUD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace GestionUsuarioCRUD.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.AddEmployee(employee);
                return Ok("Empleado añadido correctamente.");
            }
            return BadRequest(ModelState);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if ((employee != null))
            {
                await _employeeService.DeleteEmployee(id);
                return Ok("Empleado eliminado correctamente.");
            }

            return NotFound($"El empleado con el {id} no existe");
            
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var emmployeList = await _employeeService.GetAllEmployee();
            return Ok(emmployeList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await _employeeService.GetEmployeeById(id);
            if ((employee != null))
                return Ok(employee);
            return NotFound($"El empleado con el {id} no existe");
        }
    }
}
