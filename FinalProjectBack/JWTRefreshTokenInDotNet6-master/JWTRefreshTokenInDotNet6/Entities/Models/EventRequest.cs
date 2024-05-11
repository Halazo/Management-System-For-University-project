using JWTRefreshTokenInDotNet6.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class EventRequest
    {
        [Key]
        public int requestID { get; set; }
        public string name { get; set; }
        public string nameAr { get; set; }
        public string description { get; set; }
        public string descriptionAr { get; set; }
        public float price { get; set; }
        public DateTime endEvent { get; set; }
        public DateTime startEvent { get; set; }
        public int numberOfSpeaker { get; set; }
        public int ticketNo { get; set; }
        public string email { get; set; }
        public string specialRequest { get; set; }
        public bool mediaCoverage { get; set; }
        public int numberOfCamera { get; set; }
        public bool needLunch { get; set; }
        public bool isConfirm { get; set; }

        [ForeignKey("User")]
        public string userID { get; set; }

        public ApplicationUser? User { get; set; }
    }
}
