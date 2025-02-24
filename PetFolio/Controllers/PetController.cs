using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petfolio.API.UseCase.Pet.Delete;
using Petfolio.API.UseCase.Pet.GetAll;
using Petfolio.API.UseCase.Pet.GetById;
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
        // Registra um pet no sistema.
        [HttpPost]
        [ProducesResponseType(typeof(RequestPetJson), StatusCodes.Status201Created)]
        public IActionResult Register([FromBody] RequestPetJson request)
        {
            var response = new RegisterPetUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        // Atualiza um pet no sistema.
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromRoute]int id, [FromBody] RequestPetJson request)
        {
            new UpdatePetUseCase().Execute(id, request);
            return NoContent();
        }

        // Busca todos os pets, se esxitirem
        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllPetsJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAll()
        {
            var response = new GetAllPetsUseCase().Execute();
            if (response.Pets.Any())
            {
                return Ok(response);
            }
            return NotFound();
        }

        // Busca um pet pelo id
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResponseGetByIdPetJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult GetById([FromRoute] int id)
        {
            var response = new GetByIdPetUseCase().Execute(id);
            if (response.Id != -1)
            {
                return Ok(response);            
            }
            ResponseErrorsJson errors = new();
            errors.Errors.Add($"O item com o id: {id} não foi encontrado");
            return NotFound(errors);
        }

        // Deleta um pet
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(int id)
        {
            new DeletePetUserCase().Execute(id);
            return NoContent();
        }
    }
}
