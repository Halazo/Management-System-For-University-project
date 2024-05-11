using JWTRefreshTokenInDotNet6.Entities.Context;
using JWTRefreshTokenInDotNet6.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookHallController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public BookHallController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("BookHall")]
        public IActionResult AddRequest(BookHall requst)
        {
            _context.BookHalls.Add(requst);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(requst.Id);
            }
            return BadRequest(false);
        }
    }
}
