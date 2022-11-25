using ResWithASP_Net.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ResWithASP_Net.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindById(long id)
        {
            return new Person
            {
                FirstName = "Gui",
                LastName = "Lipe",
                Address = "Brusque",
                gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Guilherme" + i,
                LastName = "Lipe" + i,
                Address = "Brusque" + i,
                gender = "Male" + i
            };
        }
        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
