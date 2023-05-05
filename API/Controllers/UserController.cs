using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController, Route("[controller]"), Produces("application/json"), Consumes("application/json")]
public class UserController : ControllerBase
{
    private readonly UserService userService;

    public UserController(UserService userService)
    {
        this.userService = userService;
        Console.WriteLine("UserController created");
    }
    
    // get method
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(userService.Get());
    }
    
    // post method
    [HttpPost]
    public IActionResult Post()
    {
        userService.Post();
        return Ok("User added.");
    }
    
}