using JWTRefreshTokenInDotNet6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class StudentCertificateRequest
    {
        [Key]
        public int Id { get; set; }
        public string? PhoneNumberOne { get; set; }
        public string? PhoneNumberTwo { get; set; }
        public string? RecipientName { get; set; }
        public string? NationalIDNumber { get; set; }
        public string? AddNote { get; set; }
       // public IFormFile? Document { get; set; }
        public string Document { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.UtcNow;
        public double Cost { get; set; }

        [ForeignKey("User")]
        public string? userID { get; set; }

        public ApplicationUser? User { get; set; }
    }
}
