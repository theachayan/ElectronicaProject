using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Consolecheck
{
    public class ElectronicaContext : DbContext
        {
            public ElectronicaContext() : base("ElectronicaDB")
            {
            Database.SetInitializer<ElectronicaContext>(new DropCreateDatabaseAlways<ElectronicaContext>());           
            }
            public virtual DbSet<UserType> UserTypes { get; set; }
            public virtual DbSet<User> UserProfiles { get; set; }
            public virtual DbSet<Location> Locations { get; set; }
            public virtual DbSet<Topic> Topics { get; set; }
            public virtual DbSet<Admin> Admins { get; set; }
            public virtual DbSet<Promo> Promos { get; set; }
            public virtual DbSet<Skill> Skills { get; set; }
            public virtual DbSet<SpeakerSkillMap> SpeakerSkillMaps { get; set; }
            public virtual DbSet<Event> Events { get; set; }
            public virtual DbSet<Prerequisite> Prerequisites { get; set; }
            public virtual DbSet<Enrollment> Enrollments { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); 
            //modelBuilder.Entity<Event>()
            //    .HasRequired(d => d.UserProfileID).WithOptional().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Enrollment>()
            //.HasRequired(d => d.EventId, d => d.UserProfileID)
            //.WithMany(w=>)
            //.WillCascadeOnDelete(false);
            //         modelBuilder.Entity<Enrollment>()
            //.Property(p => p.EventId).IsOptional();
            //         modelBuilder.Entity<Enrollment>()
            //           .Property (p => p.Email).IsOptional();


            //modelBuilder.Entity<Student>()
            //   .HasMany<Course>(s => s.Courses)
            //   .WithMany(c => c.Students)
            //   .Map(cs =>
            //   {
            //       cs.MapLeftKey("StudentRefId");
            //       cs.MapRightKey("CourseRefId");
            //       cs.ToTable("StudentCourse");
            //   });





            //modelBuilder.Entity<Enrollment>()
            //   .HasMany<UserProfile>(s =>s.NavUserProfile)
            //   .WithMany(c => c.UserTypeID)
            //   .Map(cs =>
            //   {
            //       cs.MapLeftKey("EventID");
            //       cs.MapRightKey("UserProfileID");
            //       cs.ToTable("Enrollment");
            //   });


        }


    }
    }