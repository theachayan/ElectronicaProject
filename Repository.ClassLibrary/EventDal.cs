using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
    public class EventDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public Event SelectEvent(string eventName)
        {
            List<Event> eventList = context.Events.ToList();
            Event objEvent = eventList.Find(p => p.EventName == eventName);
            return objEvent;
        }
        public List<Event> DisplayEvent()
        {
            List<Event> eventList = context.Events.ToList();

            return eventList;
        }
        public List<Event> GetEvents(int UserID)
        {
            
            List<Event> eList = new List<Event>();
            var events = context.ParticipantEnrollments.Where(p => p.UserID == UserID);
            foreach (var item in events)
            {
                var eventList = context.Events.Where(p => p.EventID == item.EventID).Single();
                eList.Add(eventList);
            }
            return eList;
        }
       public string GetLocationName(int locationID)
        {
            Location objLocation = new Location();
            objLocation = context.Locations.Where(l => l.LocationID == locationID).Single();
            return objLocation.LocationName;
        }
        public string GetTopicName(int TopicID)
        {
            Topic objTopic = new Topic();
            objTopic = context.Topics.Where(l => l.TopicID == TopicID).Single();
            return objTopic.TopicName;
        }
        public string GetSpeakerName(int EventID)
        {
            SpeakerEnrollment objSpeaker = new SpeakerEnrollment();
            objSpeaker = context.SpeakerEnrollments.Where(l => l.EventID == EventID).Single();
            User objUser = new User();
            objUser = context.Users.Where(l => l.UserID == objSpeaker.UserID).Single();
            return objUser.FirstName + " " + objUser.LastName;
        }
    }
}
