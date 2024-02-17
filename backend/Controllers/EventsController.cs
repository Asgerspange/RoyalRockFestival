using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

[Route("api/events")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EventsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Events>>> GetEvents()
    {
        var events = await _context.events.ToListAsync();
        return Ok(events);
    }

    [HttpPost("create")]
    public async Task<ActionResult<Events>> PostEvents(Events events)
    {
        events.date = DateOnly.FromDateTime(DateTime.Now.Date);
        _context.events.Add(events);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetNews", new { id = events.id }, events);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Events>> GetEvents(int id)
    {
        var events = await _context.events.FindAsync(id);

        if (events == null)
        {
            return NotFound();
        }

        return events;
    }
}
