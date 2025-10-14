using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers;

[ApiController]
[Route("BasicController")]
public class MostBasicController : ControllerBase
{
    [HttpGet]
    public string GetString()
    {
        return "Hello World";
    }
}