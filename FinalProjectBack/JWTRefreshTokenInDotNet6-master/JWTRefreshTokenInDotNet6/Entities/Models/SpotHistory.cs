using JWTRefreshTokenInDotNet6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class SpotHistory
    {
        [Key]
        public int Id { get; set; }
        public int spotID { get; set; }
        public DateTime checkin { get; set; } = DateTime.UtcNow;
        public DateTime? checkout { get; set; }

        [ForeignKey("Garage")]
        public int garageID { get; set; }

        [ForeignKey("User")]
        public string userID { get; set; }

        public Garage? Garage { get; set; }
        public ApplicationUser? User { get; set; }
    }
}
