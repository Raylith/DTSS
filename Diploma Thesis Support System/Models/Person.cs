using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Diploma_Thesis_Support_System.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string contactInformation { get; set; }

    }

    public class PersonDBContext : DbContext
    {
        public DbSet<Person> people { get; set; }

    }
}