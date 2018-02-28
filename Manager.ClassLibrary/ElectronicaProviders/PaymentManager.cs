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
    public class PaymentManager
    {
        public bool AddPayment(EnrollmentDto objEnrollmentDto)
        {
            EnrollmentDal objEnrollmentDal = new EnrollmentDal();
            ParticipantEnrollment objEnrollment = new ParticipantEnrollment();
            objEnrollment.EnrollID = objEnrollmentDto.EnrollId;
            objEnrollment.PaymentStatus = objEnrollmentDto.PaymentStatus;
            bool status = objEnrollmentDal.InsertPayment(objEnrollment);
            return status;
        }
    }
}