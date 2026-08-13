using Microsoft.AspNetCore.Mvc;

namespace Ej1.Controllers
{
[ApiController]
[Route("[controller]")]
public class Ej1Controller : ControllerBase
{
    [HttpGet(Name = "Ej1Controller")]
    public int Get([FromQuery] int a, [FromQuery] int b, [FromQuery] int c)
    {
        return a + b + c; 
    }
}       
}
