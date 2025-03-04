using Petfolio.communication.Enums;

namespace Petfolio.communication.Responses;

public class ResponseShortPetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
