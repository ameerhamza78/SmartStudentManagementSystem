using Microsoft.AspNetCore.Mvc;
using SmartStudentManagementSystem.Data;
using SmartStudentManagementSystem.Models;

namespace SmartStudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_context.Students.ToList());
        }
    }
}