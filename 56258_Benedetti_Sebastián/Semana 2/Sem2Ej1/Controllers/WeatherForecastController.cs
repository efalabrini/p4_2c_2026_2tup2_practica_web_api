using Microsoft.AspNetCore.Mvc;

namespace Sem2Ej1.Controllers;

[ApiController]
[Route("[controller]")]
public class SumaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] double a, [FromQuery] double b, [FromQuery] double c)
    {
        double resultado = a + b + c;
        return Ok(new { a, b, c, resultado });
    }
}
