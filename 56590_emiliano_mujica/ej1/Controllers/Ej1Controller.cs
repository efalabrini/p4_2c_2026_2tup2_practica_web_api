using Microsoft.AspNetCore.Mvc;

namespace ej1.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet]
    public int Sumar([FromQuery] int a, [FromQuery] int b, [FromQuery] int c)
    {
        return a + b + c;
    }
}