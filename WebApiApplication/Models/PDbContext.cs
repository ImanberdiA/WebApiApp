using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApiApplication.Models
{
    public class PDbContext: DbContext
    {
        public PDbContext() : base("DefaultConnection") { }

        static PDbContext()
        {
            Database.SetInitializer<PDbContext>(new DbInitializer());
        }

        public DbSet<Person> Persons { get; set; }
    }

    public class DbInitializer: DropCreateDatabaseAlways<PDbContext>
    {
        protected override void Seed(PDbContext context)
        {
            Person p1 = new Person { IIN = "1", FirstName = "Name1", LastName = "LName1", BirthDate = "01-01-2001" };
            Person p2 = new Person { IIN = "2", FirstName = "Name2", LastName = "LName2", BirthDate = "02-02-2002" };
            Person p3 = new Person { IIN = "3", FirstName = "Name3", LastName = "LName3", BirthDate = "03-03-2003" };
            Person p4 = new Person { IIN = "4", FirstName = "Name4", LastName = "LName4", BirthDate = "04-04-2004" };
            Person p5 = new Person { IIN = "5", FirstName = "Name5", LastName = "LName5", BirthDate = "05-05-2005" };
            Person p6 = new Person { IIN = "6", FirstName = "Name6", LastName = "LName6", BirthDate = "06-06-2006" };
            Person p7 = new Person { IIN = "7", FirstName = "Name7", LastName = "LName7", BirthDate = "07-07-2007" };
            Person p8 = new Person { IIN = "8", FirstName = "Name8", LastName = "LName8", BirthDate = "08-08-2008" };
            context.Persons.AddRange(new List<Person> { p1, p2, p3, p4, p5, p6, p7, p8 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}