using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("UserType")]
    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        public string Type { get; set; }
        //1 dissaproved speaker
        //2 approved participant
        //3 approved speaker
        
    }

}
