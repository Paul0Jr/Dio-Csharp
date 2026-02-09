using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
     [HttpGet("DataHoraAtual")] 
    public IActionResult DateHour()
    {
        var obj = new 
        {
            date = DateTime.Now.ToLongDateString(),
            hour = DateTime.Now.ToLongTimeString()
        };

        return Ok(obj);
        
    }

     [HttpGet("NomePessoa")] 
    public IActionResult NameUser(string name, int age)
    {
        var message = $"Olá, mundo! Me chamo {name} e possuo {age} anos :)";
        return Ok(new {message});
    }
}