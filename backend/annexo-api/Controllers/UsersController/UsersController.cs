using annexo_api.Models;
using annexo_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace annexo_api.Controllers.UsersController;

[ApiController]
[Route("users")]

public class UsersController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
       
        var users = new List<string> { "user1", "user2", "user3" };
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] User user)
    {
       var CreateUserResult = new UsersService().CreateUserAsync(user);
       return Ok(CreateUserResult);
    }
}
