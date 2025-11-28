using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class PersonManager
    {
        private static List<Person> people;
        public PersonManager() 
        {
            if (people == null)
                people = new List<Person>();
        }

        internal IReadOnlyList<Person> GetPeople()
        {
            //return new List<Person>(people); // ye copy az list bar migardone
            return people;
        }

        internal void RemovePerson(Person person)
        {
           people.Remove(person);
        }
        internal void AddPerson(Person person)
        {
            people.Add(person);
        }
    }
}
