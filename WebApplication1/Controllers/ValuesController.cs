using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : Controller
{
    [HttpGet("string")]
    public string GetString(string value = "Ni Hao")
    {
        return value;
    }

    [HttpGet("int")]
    public int GetInt(int value)
    {
        return value;
    }

    [HttpGet("float")]
    public float GetFloat()
    {
        return 3.14f;
    }

    [HttpGet("datetime")]
    public DateTime GetDateTime()
    {
        return DateTime.Now;
    }
    
    [HttpGet("array")]
    public string[] GetArray()
    {
        var array = new string[] { "Someday", "Somewhere", "Sure" };

        return array;

    }
}