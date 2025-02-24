using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.API.UseCase.Pet.GetAll;
using Petfolio.API.UseCase.Pet.Register;
using Petfolio.API.UseCase.Pet.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(RequestPetJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute]int id, [FromBody] RequestPetJson request)
        {
            new UpdatePetUseCase().Execute(id, request);
            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetsJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var response = new GetAllPetsUseCase().Execute();
            if (response.Pets.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }
    }
}
