using ApiRocket.Comunications.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiRocket.Controllers
{ 
    public class UserController : ApiBaseController
    {
        [HttpGet] // define que o metodo seja do tipo get
        //[Route("{name}/{age}")] // cria uma rota com variaveis
        [ProducesResponseType(typeof(RequestGetUser), StatusCodes.Status200OK)] // Define o objeto que será retornado e o status code
        [ProducesResponseType(typeof(BadRequestResponse), StatusCodes.Status400BadRequest)]
        public IActionResult UpperCaseName([FromHeader]string? name)
        {
            if (string.IsNullOrEmpty(name))
            {
                BadRequestResponse badResponse = new(null)
                {
                    Title = "BadRequest",
                    Detail = "O nome ou a idade não podem estar vazios."
                };
                return BadRequest(badResponse);
            }
            RequestGetUser user = new()
            {
                Name = name,
            };
            return Ok(user);
        }

        [HttpPost]
        [Route("create/")]
        [ProducesResponseType(typeof(string) ,StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(BadRequestResponse) ,StatusCodes.Status400BadRequest)]
        public IActionResult CreateUser([FromBody] RequestRegisterUserJson request)
        {
            if (request.InvalidRegister())
            {
                BadRequestResponse badRequest = new(null)
                {
                    Title = "Bad Request",
                    Detail = "Nenhum atributo pode ser vazio."
                };
                return BadRequest(badRequest);
            }
            return Created();
        }

        [HttpPut]
        [Route("update/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult UpdateUser([FromQuery] RequestUpdateUser request)
        {
            return Ok(request);
        }

        [HttpDelete]
        [Route("delete/")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteUser()
        {
            return NoContent();
        }
    }
}
