using Petfolio.communication.Requests;
using Petfolio.communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;

public class RegisterPetUseCase
{
    public static ResponseRegisteredPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisteredPetJson
        {
            Id = 7,
            Name = request.Name,
        };
    }
}
