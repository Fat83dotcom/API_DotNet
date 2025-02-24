using Petfolio.Communication.Responses;

namespace Petfolio.API.UseCase.Pet.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetsJson Execute()
        {
            return new ResponseAllPetsJson
            {
                Pets =
                [
                    new ResponseShortPetJson
                    {
                        Id = 1,
                        Name = "Mantega",
                        Type = Communication.Enum.PetType.Cat
                    },
                    new ResponseShortPetJson
                    {
                        Id= 2,
                        Name = "Boinho",
                        Type = Communication.Enum.PetType.Cat
                    }
                ]
            };
        }
    }
}
