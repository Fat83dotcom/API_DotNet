using Petfolio.Communication.Responses;

namespace Petfolio.API.UseCase.Pet.GetById
{
    public class GetByIdPetUseCase
    {
        public ResponseGetByIdPetJson Execute(int id)
        {
            if (id == 2)
            {
                return new ResponseGetByIdPetJson
                {
                    Id = -1,
                    Name = "",
                    Type = Communication.Enum.PetType.Cat
                };

            }
            return new ResponseGetByIdPetJson
            {
                Id = id,
                Name = "Manteguinha",
                Birthday = new(2017, 8, 23),
                Type = Communication.Enum.PetType.Cat
            };
        }
    }
}
