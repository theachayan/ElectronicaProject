using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;

namespace Electronica.Manager.ElectronicaDto
{
    public class EnrollmentDto
    {
        public int EnrollId { get; set; }
        public int EnrollEventId { get; set; }

        public int EnrollMemberId { get; set; }

        public Boolean PaymentStatus { get; set; }
        
        
    }
}