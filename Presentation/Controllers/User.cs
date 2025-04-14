
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class UserController : ControllerBase
{
    public IActionResult Get()
    {
        return Ok("User");
    }

}
