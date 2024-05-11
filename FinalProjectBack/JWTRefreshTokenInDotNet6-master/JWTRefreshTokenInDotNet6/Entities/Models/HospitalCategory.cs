using System.ComponentModel.DataAnnotations;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class HospitalCategory
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
