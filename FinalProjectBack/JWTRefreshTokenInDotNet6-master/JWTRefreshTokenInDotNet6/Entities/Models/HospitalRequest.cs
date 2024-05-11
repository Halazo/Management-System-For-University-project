using JWTRefreshTokenInDotNet6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class HospitalRequest
    {
        [Key]
        public int HospitalRequestID { get; set; }
        public string? medicalImage { get; set; }
        public string? nationalityImage { get; set; }
        public string? nationality { get; set; }
        public DateTime appointment { get; set; }

        public int  HospitalCategoryDoctorId { get; set; }
        public HospitalCategoryDoctors? doctor { get; set; }
        public int HospitalCategoryId { get; set; }
        public HospitalCategory? HospitalCategory { get; set; }

        [ForeignKey("User")]
        public string? userID { get; set; }

        public ApplicationUser? User { get; set; }

    }
}
