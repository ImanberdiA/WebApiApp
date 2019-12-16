using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers
{
    public class PersonController : ApiController
    {
        static readonly IPersonRepository repository = new PersonRepository();

        public IEnumerable<Person> GetAllPersons()
        {
            return repository.GetAll();
        }
        
        public Person GetPerson(int id)
        {
            Person item = repository.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return item;
        }

        public void PostPerson(Person person)
        {
            if (ModelState.IsValid)
            {
                repository.Add(person);
            }
            else
            {
                Redirect("http://localhost:56546/Home/Error");
            }
        }

        public void PutPerson(Person person)
        {
            repository.Update(person);
        }

        public void DeletePerson(int id)
        {
            Person person = repository.Get(id);

            if (person == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            repository.Remove(person);
        }
    }
}