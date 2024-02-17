using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

[Route("api/news")]
[ApiController]
public class NewsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

        public NewsController(ApplicationDbContext context)
        {
            _context = context;
        }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<News>>> GetNews()
    {
        var news = await _context.news.ToListAsync();
        return Ok(news);
    }

    [HttpPost("create")]
    public async Task<ActionResult<News>> PostNews(News news)
    {
        news.date = DateOnly.FromDateTime(DateTime.Now.Date);
        _context.news.Add(news);
        await _context.SaveChangesAsync();
        return CreatedAtAction("GetNews", new { id = news.id }, news);
    }
}
