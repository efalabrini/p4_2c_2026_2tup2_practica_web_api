using Microsoft.AspNetCore.Mvc;

namespace ej1.Controllers;

[ApiController]
[Route("[controller]")]
public class ej1Controller : ControllerBase
{
    [HttpGet]
    public int Get([FromQuery] int n1, [FromQuery] int n2, [FromQuery] int n3 )
    {
        return n1 + n2 + n3;
    }
}
