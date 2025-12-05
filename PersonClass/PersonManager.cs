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
        internal OperationResult AddPerson(Person person)
        {

            if (string.IsNullOrWhiteSpace(person.FirstName)
                || string.IsNullOrWhiteSpace(person.LastName)) 
            {
                return OperationResult.Failed("One field is empty");
            }

            if (!person.NationalId.ValidateNationalId())
            {
                return OperationResult.Failed("National Code format is incorrect");
            }

            if (person.Gender == Genders.unknow)
            {
                return OperationResult.Failed("Please select a correct Gender");
            }
            people.Add(person);
            return OperationResult.Success();
            
        }
        

    }
}
