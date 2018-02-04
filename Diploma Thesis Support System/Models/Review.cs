using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Diploma_Thesis_Support_System.Models
{
    public class Review
    {
        public int reviewID { get; set; }
        public string reviewContent { get; set; }

    }

    public class ReviewDBContext : DbContext
    {
        public DbSet<Review> reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}