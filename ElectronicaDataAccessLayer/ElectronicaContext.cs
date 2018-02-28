using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ModelEntities.ClassLibrary;
namespace Repository.ClassLibrary
{
    public class Electronica_Context : DbContext
    {
        public Electronica_Context() : base("ElectronicaDB")
        {
            // Database.SetInitializer<Electronica_Context>(new DropCreateDatabaseAlways<Electronica_Context>());           
        }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Promo> Promos { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<SpeakerLogin> SpeakerLogins { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<SpeakerProfile> SpeakerProfiles { get; set; }
        public virtual DbSet<SpeakerSkillMap> SpeakerSkillMaps { get; set; }
        public virtual DbSet<Prerequisite> Prerequisites { get; set; }
       
        }
    }


