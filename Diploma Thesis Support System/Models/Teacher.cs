using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Diploma_Thesis_Support_System.Models
{
    public class Teacher : Person
    {
        public bool isDean { get; set; }
        public Topic promotedTopic { get; set; }
        public Review review { get; set; }

    }

    public class TeacherDBContext : DbContext
    {
        public DbSet<Teacher> teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}