using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.communication.Requests;
using Petfolio.communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
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
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        UpdatePetUseCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    // [ProducesResponseType(typeof(List<ResponseShortPetJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseAllPetJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll([FromRoute] int id, [FromBody] RequestPetJson request)
    {
        return Ok();
    }
}
