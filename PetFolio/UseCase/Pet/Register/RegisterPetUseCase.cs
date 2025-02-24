using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.UseCase.Pet.Register
{
    public class RegisterPetUseCase
    {
        public ResponseRegisterPetJson Execute(RequestPetJson request)
        {
            return new ResponseRegisterPetJson
            {
                Id = 2,
                Name = request.Name,
            };
        }
    }
}
