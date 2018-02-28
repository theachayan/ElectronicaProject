using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Repository
{
    public class ParticipantDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public bool InsertParticipant(User objParticipant)
        {
             //context.Database.Delete();
           // context.Database.Create();
            context.Users.Add(objParticipant);
            context.SaveChanges();
            return true;
        }
    }
}
