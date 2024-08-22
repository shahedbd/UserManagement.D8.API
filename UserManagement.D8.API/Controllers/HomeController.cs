using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UserManagement.D8.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("getuser")]
        public IActionResult Get()
        {
            var result = SeedData.GetUsers();
            return Ok(result);
        }
    }
}
