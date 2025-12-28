using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class TeacherManager
    {
        private static List<Teacher> teachers;
        public TeacherManager()
        {
            if (teachers == null)
            {
                teachers = new List<Teacher>();
            }
        }
        internal IReadOnlyList<Teacher> GetTeacher()
        {
            //return new List<Student>(people); // ye copy az list bar migardone
            return teachers;
        }

        internal void Remove(Teacher teacher)
        {
            teachers.Remove(teacher);
        }
        internal void Add(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        internal void Edit(Teacher teacher)
        {

        }

        public OperationResult Validate(Teacher person)
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
            return OperationResult.Success();
        }

    }
}
