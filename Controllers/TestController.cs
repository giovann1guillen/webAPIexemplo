using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "My App is Working";
    }

    [HttpGet("quadratica{x}")]
    public string Get(int x, int a = 1, int b = 0, int c = 0)
    {
        int resultado = a * x * x + b * x + c;
        return resultado.ToString();
    }
    [HttpGet("solucao")]
    public object Get(double a  = 1, double  b = 0, double c = 0);
    {
        if(a == 0)
        {
            return{
            status = "fail";
            message = "a nao pode ser 0";
            };
        }
    
    double delta = b * b - 4 * a * c ;
        if(delta < 0)
        {   return{
            status = "fail";
            message = "delta nao pode ser negativo"
            };
        }
    double x1 = (-b + math.sqrt(delta)/2*a);
    double x2 = (-b - math.sqrt(delta)/2*a);
}