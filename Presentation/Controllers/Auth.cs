
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class AuthController : ControllerBase
{

    [HttpPost("register")]
    public IActionResult Register()
    {
        return Ok("Register");
    }

    [HttpPost("login")]
    public IActionResult Login()
    {
        return Ok("Login");
    }

    [HttpPost("logout")]
    public IActionResult Logout()
    {
        return Ok("Logout");
    }

    [HttpGet("google")]
    public IActionResult GoogleLogin()
    {
        return Ok("Google login");
    }

    [HttpGet("google-callback")]
    public IActionResult GoogleLoginCallback()
    {
        return Ok("Google login callback");
    }

}
