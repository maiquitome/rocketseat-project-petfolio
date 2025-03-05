using Petfolio.communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Rex",
            Birthday = new DateTime(year: 2023, month: 10, day: 10),
            Type = communication.Enums.PetType.Dog
        };
    }
}
