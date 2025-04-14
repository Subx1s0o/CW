
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class WalletController : ControllerBase
{
    [HttpGet()]
    public IActionResult Get()
    {
        return Ok("Wallet");
    }

    [HttpGet("{currencyType}")]
    public IActionResult GetByCurrencyType(string currencyType)
    {
        return Ok("Wallet");
    }
}
