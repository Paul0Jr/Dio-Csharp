using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult DateHour()
    {
        var obj = new 
        {
            Date = DateTime.Now()
        }
        
        return View();
        
    }
}