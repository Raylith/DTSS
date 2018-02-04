using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Diploma_Thesis_Support_System.Models
{
    public class Thesis
    {
        public Topic topicName { get; set; }
        public string details { get; set; }
        public Review thesisReview { get; set; }

    }

    public class ThesisDBContext : DbContext
    {
        public DbSet<Thesis> theses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}