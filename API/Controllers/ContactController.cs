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

    //POST
    [HttpPost("CreateContact")]
    public IActionResult Create(Contact contact)
    {
        _context.Add(contact);
        _context.SaveChanges();
        return Ok();
    }

    //GET
    [HttpGet("{id}")]
    public IActionResult Search ([FromRoute] int id)
    {
        var contact = _context.Contacts.Find(id);
        if (contact == null){ return NotFound(); }
        return Ok(contact);
    }
    
    //GET
    [HttpGet("Obtain/{name}")]
    public IActionResult Search (string name)
    {
        var contacts = _context.Contacts.Where(x => x.Name.Contains(name));
        //if (contacts == null){ return NotFound(); }
        return Ok(contacts);
    }
    
    //PUT
    [HttpPut("Update/{id}")]
    public IActionResult Update(int id, Contact contact)
    {
        var contactDb = _context.Contacts.Find(id);

        if (contactDb == null) { return NotFound(); }

        contactDb.Name = contact.Name;
        contactDb.Phone = contact.Phone;
        contactDb.Active = contact.Active;

        _context.Contacts.Update(contactDb);
        _context.SaveChanges();

        return Ok(contactDb);
    }

    //DELETE
    [HttpDelete("{id}")]
    public IActionResult Delete ([FromRoute] int id)
    {
        var contact = _context.Contacts.Find(id);
        if (contact == null){ return NotFound(); }
        
        _context.Contacts.Remove(contact);
        _context.SaveChanges();
        return NoContent();
    }
}