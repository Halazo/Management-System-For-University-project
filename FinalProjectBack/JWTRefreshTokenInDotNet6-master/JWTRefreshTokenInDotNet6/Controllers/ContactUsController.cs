using JWTRefreshTokenInDotNet6.Entities.Context;
using JWTRefreshTokenInDotNet6.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ContactUsController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("AddContactUs")]
        public IActionResult AddGarage(ContactUs contactUs)
        {
            _context.ContactUs.Add(contactUs);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }

        [HttpGet("GetContactUsById")]

        public IActionResult GetContactUsById(int id)
        {
            var result = _context.ContactUs.Where(s => s.Id == id);

            return Ok(result);
        }


        [HttpGet("GetAllContactUs")]

        public IActionResult GetAllContactUs()
        {
            var result = _context.ContactUs.ToList();

            return Ok(result);
        }

    }
}
