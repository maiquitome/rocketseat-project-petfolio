using Petfolio.communication.Enums;

namespace Petfolio.communication.Responses;

public class ResponsePetJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetType Type { get; set; }
}
