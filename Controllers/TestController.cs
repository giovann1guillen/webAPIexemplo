using Microsoft.AspNetCore.Mvc;

[ApiController]
[Router("test/")]
public class TestController : ContorlleBase
{
    [HttpGet]
    public string Get()
    {
        return "My App is Working";
    }
}