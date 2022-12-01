using ResWithASP_Net.Model;
using ResWithASP_Net.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ResWithASP_Net.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySQLContext _context;

        public PersonServiceImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            return _context.Person.ToList();
        }


        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Gui",
                LastName = "Lipe",
                Address = "Brusque",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
    }
}
