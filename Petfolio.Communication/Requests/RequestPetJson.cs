using Petfolio.Communication.Enum;

namespace Petfolio.Communication.Requests
{
    public class RequestPetJson
    {
        public required string Name { get; set; }
        public DateTime Birthday { get; set; }
        public PetType Type { get; set; }
    }
}
