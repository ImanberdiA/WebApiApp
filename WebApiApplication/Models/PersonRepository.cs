using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiApplication.Models
{
    public class PersonRepository: IPersonRepository
    {
        PDbContext db = new PDbContext();

        public IEnumerable<Person> GetAll()
        {
            return db.Persons.AsNoTracking().ToList();
        }

        public Person Get(int id)
        {
            Person person = db.Persons.AsNoTracking().FirstOrDefault(p => p.Id == id);
            return person;
        }

        public void Add(Person item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            db.Persons.Add(item);
            db.SaveChanges();
        }

        public void Remove(Person item)
        {
            //db.Persons.Attach(item);
            db.Persons.Remove(item);
            db.SaveChanges();
        }

        public void Update(Person item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            //db.Persons.Attach(item);
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}