using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWTRefreshTokenInDotNet6.Entities.Models
{
    public class EventSpeaker
    {
        [Key]
        public int EventSpeakerID { get; set; }
        public DateTime speaketTalkingStart { get; set; }
        public DateTime speaketTalkingEnd { get; set; }
        public string speakerImage { get; set; }
        public string speakerBio { get; set; }
        public string speakerName { get; set; }

        [ForeignKey("eventID")]
        public int eventID { get; set; }
        public Event? Event { get; set; }
    }
}
