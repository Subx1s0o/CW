
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    [HttpPost()]
    public IActionResult Create()
    {
        return Ok("Transaction");
    }

    [HttpGet()]
    public IActionResult GetAll()
    {
        return Ok("Transaction");
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        return Ok("Transaction");
    }

}
