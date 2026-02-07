using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Student : Person
    {
        //Data Source =.; Initial Catalog = School; Integrated Security = True;
        public int StudentCode { get; set; }
        public Grades Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}  ,  {NationalId}  ,  {Grade}  ,  {StudentCode.ToString()}";
        }






    }
}
