using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    internal class StudentManager
    {
        private static List<Student> students;
        public StudentManager()
        {
            if (students == null)
            {
                students = new List<Student>();
            }
        }
        internal IReadOnlyList<Student> GetStudent()
        {
            //return new List<Student>(people); // ye copy az list bar migardone
            return students;
        }

        internal void Remove(Student student)
        { 
            students.Remove(student);
        }
        internal void Add(Student student)
        {
            students.Add(student);
        }

        public OperationResult<Student> GetByNationalcode(string nationalcode)
        {
            try
            {
                Student student = students.FirstOrDefault(t => t.NationalId == nationalcode);

                if (student == null)
                {
                    return OperationResult<Student>.Failed("not find");
                }
                return OperationResult<Student>.Success(student);
            }
            catch (Exception)
            {
                return OperationResult<Student>.Failed("system Error");
            }
        }

        public OperationResult Validate(Student person)
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

            if (person.Grade == Grades.unknow)
            {
                return OperationResult.Failed("Please select a correct Grade");
            }

            return OperationResult.Success();
        }

    }
}
