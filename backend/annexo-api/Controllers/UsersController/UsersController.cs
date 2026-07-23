using Microsoft.AspNetCore.Mvc;

namespace annexo_api.Controllers.UsersController;

[ApiController]
[Route("users")]

public class UsersController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        // Logic to retrieve users from the database or any other source
        var users = new List<string> { "user1", "user2", "user3" };
        return Ok(users);
    }

}
