using Microsoft.AspNetCore.Mvc;
using Petfolio.communication.Requests;
using Petfolio.communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPetJson request)
    {
        return Created();
    }
}
