using JWTRefreshTokenInDotNet6.Entities.Context;
using JWTRefreshTokenInDotNet6.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalRequestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public HospitalRequestController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("RequstAppointment")]
        public IActionResult AddRequest(HospitalRequest requst)
        {
            _context.HospitalRequests.Add(requst);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(requst.HospitalRequestID);
            }
            return BadRequest(false);
        }
    }
}
