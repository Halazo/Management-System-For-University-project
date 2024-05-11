using JWTRefreshTokenInDotNet6.Entities.Context;
using JWTRefreshTokenInDotNet6.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTRefreshTokenInDotNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GarageController(ApplicationDbContext context)
        {
                _context = context;
        }

        [HttpPost("AddGarage")]
        public IActionResult AddGarage(Garage garage)
        {
            _context.Garages.Add(garage);
            var result =_context.SaveChanges();
            if (result>0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }

        [HttpPost("AddSpot")]
        public IActionResult AddSpot(Spot spot)
        {
            _context.Spots.Add(spot);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }



        [HttpDelete("DeleteSpot")]
        public IActionResult DeleteSpot(int id)
        {
            var spot= _context.Spots.Find(id);

            _context.Spots.Remove(spot);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }



        [HttpGet("AvaliableGarageSpot")]
        public IActionResult AvaliableGarageSpot(int garageId)
        {
          var result=   _context.Spots.Where(s=>s.garageID==garageId && s.IsavailableSpot==true);
           
            return Ok(result);
        }



        [HttpPost("TakeSpot")]
        public IActionResult TakeSpot(SpotHistory spotHistory)
        {
          var spot=   _context.Spots.Find(spotHistory.spotID);
            if (spot is null)
            {
                return BadRequest("this spot not found");

            }
            spot.IsavailableSpot=false;
            _context.SpotHistories.Add(spotHistory);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }

        [HttpPost("TakeOfSpot")]
        public IActionResult TakeOfSpot(SpotHistory spotHistory)
        {
            var spot = _context.Spots.Find(spotHistory.spotID);
            if (spot is null)
            {
                return BadRequest("this spot not found");

            }
            spot.IsavailableSpot = true;

            _context.SpotHistories.Update(spotHistory);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return Ok(true);
            }
            return BadRequest(false);
        }
    }
}
