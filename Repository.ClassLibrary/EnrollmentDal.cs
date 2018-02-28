using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Repository
{
    public class EnrollmentDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public bool InsertEnrollment(ParticipantEnrollment obj)
        {
            //context.Database.Delete();
            //context.Database.Create();
            context.ParticipantEnrollments.Add(obj);
            context.SaveChanges();
            return true;
        }
        public bool InsertPayment(ParticipantEnrollment obj)
        {

            ParticipantEnrollment enrollment = context.ParticipantEnrollments.Find(obj.EnrollID);
            enrollment.PaymentStatus = true;
            context.SaveChanges();
            return true;
        }
    }
}
