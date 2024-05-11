using JWTRefreshTokenInDotNet6.Entities.Context;
using JWTRefreshTokenInDotNet6.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CertificateController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("RequstCertificate")]
        public IActionResult AddRequest(StudentCertificateRequest requst)
        {
            _context.StudentCertificateRequests.Add(requst);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(requst.Id);
            }
            return BadRequest(false);
        }
    }
}
