using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.communication.Requests;
using Petfolio.communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestPetJson request)
    {
        ResponseRegisteredPetJson response = RegisterPetUseCase.Execute(request);

        return Created(
            uri: string.Empty,
            value: response
        );
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        return NoContent();
    }
}
