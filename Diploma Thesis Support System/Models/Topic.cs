using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Diploma_Thesis_Support_System.Models
{
    public class Topic
    {
        public string name { get; set; }

    }

    public class TopicDBContext : DbContext
    {
        public DbSet<Topic> topics { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}