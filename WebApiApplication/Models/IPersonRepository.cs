using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiApplication.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();

        
        Person Get(int id);

        void Add(Person item);

        void Remove(Person item);

        void Update(Person item);
    }
}
