using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRocket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Get(string? name, string? age)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age))
            {
                return BadRequest();
            }
            if (int.TryParse(age, out int _))
            {
                Response response = new(name, int.Parse(age));
                return Ok(response); 
            }
            return BadRequest();
        }
    }
}
