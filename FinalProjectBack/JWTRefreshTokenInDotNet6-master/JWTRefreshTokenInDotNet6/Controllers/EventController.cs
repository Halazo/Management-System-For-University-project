using JWTRefreshTokenInDotNet6.Entities.Context;
using JWTRefreshTokenInDotNet6.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public EventController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("AddEvent")]
        public IActionResult AddEvent(Event eventData)
        {
            _context.Events.Add(eventData);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }

        [HttpPost("AddSeats")]
        public IActionResult AddSeats(EventSeats seat)
        {
            _context.EventSeats.Add(seat);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }


        [HttpDelete("DeleteSeats")]
        public IActionResult DeleteSeats(int id)
        {
            var seeat = _context.EventSeats.Find(id);

            _context.EventSeats.Remove(seeat);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }
        [HttpGet("AvaliablEventSeats")]

        public IActionResult AvaliablEventSeats(int eventId)
        {
            var result = _context.EventSeats.Where(s => s.EventID == eventId && s.IsavailableSeat == true);

            return Ok(result);
        }

    }
}
