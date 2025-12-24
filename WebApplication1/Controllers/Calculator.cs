using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : Controller
{
    [HttpGet("add")]
    public double Add(double a, double b)
    {
        return a + b;
    }
    
    [HttpGet("substract")]
    public double Substract(double a, double b)
    {
        return a - b;
    }
    
    [HttpGet("multiply")]
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    
    [HttpGet("divide")]
    public ActionResult<double> Divide(double a, double b)
    {
        if (b == 0)
        {
            return BadRequest("На нуль делить нельзя!");
        }
        return a / b;
    }
}