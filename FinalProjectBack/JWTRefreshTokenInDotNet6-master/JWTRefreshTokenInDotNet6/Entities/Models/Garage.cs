using System.ComponentModel.DataAnnotations;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class Garage
    {
        [Key]
        public int garageID { get; set; }
        public int spotsNo { get; set; }
        public string locationLink { get; set; }
        public string location { get; set; }

        public List<Spot>? Spots { get; set; }
    }
}
