using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class Spot
    {
        [Key]
        public int spotID { get; set; }
        public bool IsavailableSpot { get; set; }
        public string? SpotName { get; set; }
        [ForeignKey("Garage")]
        public int garageID { get; set; }
        public Garage? Garage { get; set; }

    }
}
