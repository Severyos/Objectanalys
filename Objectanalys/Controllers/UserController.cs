using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Objectanalys.Factories;

namespace Objectanalys.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult Create()
    {
        var user = UserResponseFactory.Create();

        return Created("", user);
    }
}
