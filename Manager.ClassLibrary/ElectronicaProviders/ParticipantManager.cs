using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Repository;
using Electronica.Manager.ElectronicaDto;
using Electronica.Entity;
namespace Electronica.Manager.ElectronicaProviders
{
    public class ParticipantManager
    {
        public bool AddParticipant(ParticipantDto objParticipantDto)
        {
            ParticipantDal objParticipantDal = new ParticipantDal();
            User objParticipant = new User();
            objParticipant.FirstName = objParticipantDto.FirstName;
            objParticipant.Email = objParticipantDto.Email;
            objParticipant.Mobile = objParticipantDto.Mobile;
            objParticipant.Password = objParticipantDto.Password;
            objParticipant.Education = objParticipantDto.Education;
            objParticipant.LastName = objParticipantDto.LastName;
            objParticipant.SelfDescription = objParticipantDto.SelfDescription;
            objParticipant.ProfilePhoto = objParticipantDto.ProfilePicture;
            objParticipant.UserType = 3;
            bool status= objParticipantDal.InsertParticipant(objParticipant);
            return status;
        }
    }
}
