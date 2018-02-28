using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("SpeakerSkillMap")]
    public class SpeakerSkillMap
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("SkillNavigation")]
        public int SkillID { get; set; }
        public Skill SkillNavigation { get; set; }

        [ForeignKey("SpeakerNavigation")]
        public int SpeakerProfileID { get; set; }
        public User SpeakerNavigation { get; set; }

        public int Rating { get; set; }
       

    }
}
