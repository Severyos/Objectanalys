using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Objectanalys.Models.DTOs;
using Objectanalys.Repositories;

namespace Objectanalys.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly UserRepository _userRepo;

    public AdminController(UserRepository userRepo)
    {
        _userRepo = userRepo;
    }



    [HttpPost]
    public async Task<IActionResult> Create(UserRequest req)
    {
        if (ModelState.IsValid)
        {
            UserResponse res = await _userRepo.CreateAsync(req);
            if (res != null)
                return Created("", res);
        }

        return BadRequest();
    }
}
