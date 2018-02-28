using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
using Electronica.Repository;
using Electronica.Manager.ElectronicaDto;

namespace Electronica.Manager.ElectronicaProviders
{
    public class EventManager
    {
        
        //List<ParticipantEventDto> eventList = new List<ParticipantEventDto>();
        EventDal objEventDal = new EventDal();
        
        public EventDto GetEvent(string eventName)
        {
            Event objEvent = objEventDal.SelectEvent(eventName);
            EventDto objEventDto = new EventDto();
            objEventDto.EventDescription = objEvent.EventDescription;
            return objEventDto;
        } 
        public List<ParticipantEventDto> DisplayEvent()
        {
            List<Event> newList = objEventDal.DisplayEvent();
            List<ParticipantEventDto> listEventDto = new List<ParticipantEventDto>();
            EventDto objEventDto = new EventDto();
            foreach (Event item in newList)
            {
                if (item.EventStatus != 3)
                {
                    listEventDto.Add(MapperFunction(item));
                } 
            }
            return listEventDto;
        }
       //Past events
            public List<ParticipantEventDto> GetPastEvent(int UserID)
            {
            EventDal eventDalObj = new EventDal();
            List<Event> eventList = eventDalObj.GetEvents(UserID);
            List<ParticipantEventDto> pastEventList = new List<ParticipantEventDto>();
               foreach (var item in eventList)
                {
                    
                   if(item.EventStatus==3)
                       {
                        pastEventList.Add(MapperFunction(item));
                        }
                }
                return pastEventList;
            }
        public List<ParticipantEventDto> GetShowEvent(int UserID)
        {
            EventDal eventDalObj = new EventDal();
            List<Event> eventList = eventDalObj.GetEvents(UserID);
            List<ParticipantEventDto> showEventList = new List<ParticipantEventDto>();
            foreach (var item in eventList)
            {
                if (item.EventStatus != 3)
                {
                    showEventList.Add(MapperFunction(item));
                }
            }
            return showEventList;
        }
        public ParticipantEventDto MapperFunction(Event objEvent)
        {
            ParticipantEventDto objEventDto = new ParticipantEventDto();
            objEventDto.EventDescription = objEvent.EventDescription;
            objEventDto.EventEndDate = objEvent.EventEndDate;
            objEventDto.EventFee = objEvent.EventFee;
            objEventDto.EventID = objEvent.EventID;
            objEventDto.EventIntake = objEvent.EventIntake;
            objEventDto.EventName = objEvent.EventName;
            objEventDto.EventStartDate = objEvent.EventStartDate;
            objEventDto.EventStatus = objEvent.EventStatus;
            objEventDto.LocationName = objEventDal.GetLocationName(objEvent.LocationID);
            objEventDto.PromoCode = objEvent.PromoCode;
            objEventDto.PromoDiscount =objEvent.PromoDiscount;
            objEventDto.PromoExpiry = objEvent.PromoExpiry;
            objEventDto.TopicName = objEventDal.GetTopicName(objEvent.TopicID);
            objEventDto.SpeakerName = objEventDal.GetSpeakerName(objEvent.EventID);
            
            return objEventDto;
        }
        }

    }

