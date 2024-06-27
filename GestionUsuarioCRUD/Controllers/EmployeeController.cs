using GestionUsuarioCRUD.Models.Entities;
using GestionUsuarioCRUD.Models.ModelsDTO;
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
            return BadRequest($"El modelo {ModelState} es incorrecto");
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
            if (employee != null)
                return Ok(employee);
            return NotFound($"El empleado con el {id} no existe");
        }

        [HttpPost("update/{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, Employee newEmployee)
        {
            var existingEm = await _employeeService.GetEmployeeById(id);
            if(existingEm == null)
                return NotFound($"El empleado con el {id} no existe");
            if (ModelState.IsValid)
            {
                if (existingEm.Equals(newEmployee))
                    return BadRequest($"No se esta actualizando ningun campo del empleado con el {id}");
            
                var updateemployee = await _employeeService.UpdateEmployee(existingEm, newEmployee);
                return Ok(updateemployee);
            }
            return BadRequest("El modelo no es correcto");
        }

        [HttpGet("salary/{id}")]
        public async Task<IActionResult> GetSalaryEmployeeById(int id)
        {
            var existingEm = await _employeeService.GetEmployeeById(id);
            if (existingEm == null)
                return NotFound($"El empleado con el {id} no existe");
            var employeeDTO = await _employeeService.GetSalaryEmployeeById(id);
            return Ok(employeeDTO);
        }
    }
}
