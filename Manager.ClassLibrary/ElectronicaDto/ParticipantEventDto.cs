using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Manager.ElectronicaDto
{
    public class ParticipantEventDto
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string SpeakerName { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public string LocationName { get; set; }
        public string PromoCode { get; set; }
        public string TopicName { get; set; }
        public DateTime PromoExpiry { get; set; }

        public int PromoDiscount { get; set; }

        public int EventFee { get; set; }

        public int EventIntake { get; set; }

        public int EventStatus { get; set; }

        public string EventDescription { get; set; }
    }

}
