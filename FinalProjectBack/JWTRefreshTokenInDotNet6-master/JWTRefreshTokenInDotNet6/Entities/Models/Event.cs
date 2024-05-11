using System.ComponentModel.DataAnnotations;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class Event
    {
        [Key]
        public int eventID { get; set; }
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
        public List<EventSpeaker>? EventSpeakers { get; set; }
    }
}
