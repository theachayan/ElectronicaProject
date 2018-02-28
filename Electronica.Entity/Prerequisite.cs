using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Prerequisite")]
    public class Prerequisite
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("EventNavigation")]
        public int EventID { get; set; }
        public Event EventNavigation { get; set; }

        public string FilePath { get; set; }
    }

}

