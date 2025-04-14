
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class WalletController : ControllerBase
{
    [HttpGet()]
    public IActionResult Get()
    {
        return Ok("Wallet");
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        return Ok("Wallet");
    }
}
