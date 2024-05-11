using JWTRefreshTokenInDotNet6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class AttendEvent
    {
        [Key]
        public int Id { get; set; }
        public bool isPaid { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Event")]
        public int eventID { get; set; }
        public ApplicationUser? User { get; set; }
        public Event? Event { get; set; }
    }
}
