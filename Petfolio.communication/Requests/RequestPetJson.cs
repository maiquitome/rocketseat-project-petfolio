using Petfolio.communication.Enums;

namespace Petfolio.communication.Requests;

public class RequestPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetType Type { get; set; }
}
