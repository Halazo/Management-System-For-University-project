using System.ComponentModel.DataAnnotations;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }
        public  string? Email { get; set; }
        public  string? Phone { get; set; }
        public  string ?Subject { get; set; }
        public  string? Content { get; set; }
    }
}
