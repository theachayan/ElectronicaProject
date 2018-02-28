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
    public class EnrollmenttManager
    {
        public bool AddEnrollment(EnrollmentDto objEnrollmentDto)
        {
            EnrollmentDal objEnrollmentDal = new EnrollmentDal();
            ParticipantEnrollment objEnrollment = new ParticipantEnrollment();
            objEnrollment.EnrollID = objEnrollmentDto.EnrollId;
            objEnrollment.PaymentStatus = false;
            objEnrollment.EventID= objEnrollmentDto.EnrollEventId;
            objEnrollment.UserID = objEnrollmentDto.EnrollMemberId;
            bool status = objEnrollmentDal.InsertEnrollment(objEnrollment);
            return status;
        }
    }
}