using Microsoft.AspNetCore.Mvc;
using API.Entities;
using API.Context;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly ScheduleContext _context;
    
    public ContactController(ScheduleContext context)
    {
        _context = context;
    }
    
     [HttpPost("ContactInfo")] 
    public IActionResult Create(Contact contact)
    {
        _context.Add(contact);
        _context.SaveChanges();
        return Ok();
    }
}