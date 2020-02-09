using System.Threading.Tasks;
using WebApplicationCoreAngularLogin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationCoreAngularLogin.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly WebApplicationCoreAngularLoginContext _context;
        public BookController(WebApplicationCoreAngularLoginContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var data = await _context.Book.ToListAsync();
            return Ok(data);
        }
    }
}
