using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KEWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetAllStudents()
        {

            string[] studentNames = new string[] { "Hadija", "Halima", "Amina", "Mwanaisha"};
            return Ok(studentNames);
        }
    }
}
