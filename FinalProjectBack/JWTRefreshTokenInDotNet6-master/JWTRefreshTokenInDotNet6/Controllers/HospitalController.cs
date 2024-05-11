using JWTRefreshTokenInDotNet6.Entities.Context;
using JWTRefreshTokenInDotNet6.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        public HospitalController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpPost("AddHospitalCategory")]
        public IActionResult AddHospitalCategory(HospitalCategory HospitalCategory)
        {
            _context.HospitalCategories.Add(HospitalCategory);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }

        [HttpPost("AddHospitalCategoryDoctors")]
        public IActionResult AddHospitalCategoryDoctors(HospitalCategoryDoctors HospitalCategoryDoctors)
        {
            _context.HospitalCategoryDoctors.Add(HospitalCategoryDoctors);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }


        [HttpDelete("DeleteHospitalCategoryDoctors")]
        public IActionResult DeleteHospitalCategoryDoctors(int id)
        {
            var spot = _context.HospitalCategoryDoctors.Find(id);

            _context.HospitalCategoryDoctors.Remove(spot);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }

        [HttpGet("GetHospitalCategoryDoctorsByCategoryId")]

        public IActionResult GetHospitalCategoryDoctorsByCategoryId(int categoryId)
        {
            var result = _context.HospitalCategoryDoctors.Where(s => s.HospitalCategoryId == categoryId);

            return Ok(result);
        }
    }
}
