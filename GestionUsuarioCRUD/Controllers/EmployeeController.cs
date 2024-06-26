using GestionUsuarioCRUD.Models.Entities;
using GestionUsuarioCRUD.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

            await _employeeService.DeleteEmployee(id);
            return Ok("Empleado eliminado correctamente.");
        }
    }
}
