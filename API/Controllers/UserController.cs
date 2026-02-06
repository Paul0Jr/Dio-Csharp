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
}