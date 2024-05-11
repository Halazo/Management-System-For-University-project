using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class HospitalCategoryDoctors
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey("HospitalCategory")]
        public int HospitalCategoryId { get; set; }
        public HospitalCategory? HospitalCategory { get; set; }
    }
}
