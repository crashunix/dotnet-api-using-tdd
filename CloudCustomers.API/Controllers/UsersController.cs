using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }
    //public UsersController(ILogger<UsersController> logger)
    //{
    //    _logger = logger;
    //}

    [HttpGet(Name = "GetUsers")]
    public async Task<IActionResult> Get()
    {
        var users = await _usersService.GetAllUsers();
        if(users.Any())
        { 
            return Ok(users);
        } else
        {
            return NotFound();
        }
    }
}
