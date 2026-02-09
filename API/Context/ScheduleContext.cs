using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Context;
public class ScheduleContext : DbContext
{
    public ScheduleContext(DbContextOptions <ScheduleContext> options) : base(options)
    { 

    }
    public DbSet<Contact> Contacts { get; set; }
    //public DbSet <Task> Tasks {get; set; } 
}