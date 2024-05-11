using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class EventSeats
    {
        [Key]
        public int Id { get; set; }
        public bool IsavailableSeat { get; set; }
        public string? SeatName { get; set; }
        [ForeignKey("Event")]
        public int EventID { get; set; }
        public Event? Event { get; set; }
    }
}
