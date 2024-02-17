using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
    {
        var users = await _context.rock_users.ToListAsync();
        return Ok(users);
    }

    [HttpPost("login")]
    public async Task<ActionResult<Users>> Login(Users model)
    {
        var user = await _context.rock_users.FirstOrDefaultAsync(u => u.username == model.username && u.username == model.username);

        if (user == null)
        {
            return NotFound("Invalid username or password");
        }

        return Ok(user);
    }
}
