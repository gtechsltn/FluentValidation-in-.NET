using FluentValidationWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserModel userModel)
        {
            // If validation fails, a 400 Bad Request will be returned automatically.
            return CreatedAtAction(nameof(CreateUser), userModel);
        }
    }
}
