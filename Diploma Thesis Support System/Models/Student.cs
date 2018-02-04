using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Diploma_Thesis_Support_System.Models
{
    public class Student : Person
    {
        public int studentID { get; set; }
        public string studentPhoto { get; set; }
        public Topic thesisTopic { get; set; }

    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }


}