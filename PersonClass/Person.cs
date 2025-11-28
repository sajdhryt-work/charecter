using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public string Gender { get; set; }
        public string FullName
        {
            get
            { return $"{FirstName} {LastName}"; }
        }

        private bool ValidateNationalId(string code_melli)
        {
            bool valid = true;
            try
            {
                char[] chArray = code_melli.ToCharArray();
                int[] numArray = new int[chArray.Length];
                for (int i = 0; i < chArray.Length; i++)
                {
                    numArray[i] = (int)char.GetNumericValue(chArray[i]);
                }
                int num2 = numArray[9];
                switch (code_melli)
                {
                    case "0000000000":
                    case "1111111111":
                    case "2222222222":
                    case "3333333333":
                    case "4444444444":
                    case "5555555555":
                    case "6666666666":
                    case "7777777777":
                    case "8888888888":
                    case "9999999999":
                        valid = false;
                        break;
                }
                int num3 = ((((((((numArray[0] * 10) + (numArray[1] * 9)) + (numArray[2] * 8)) + (numArray[3] * 7)) + (numArray[4] * 6)) + (numArray[5] * 5)) + (numArray[6] * 4)) + (numArray[7] * 3)) + (numArray[8] * 2);
                int num4 = num3 % 11;
                if (!(((num4 == 0 && num2 == 0) || (num4 == 1 && num2 == 1)) || (num4 > 1 && num2 == (11 - num4))))
                {
                    valid = false;
                }
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
        public OperationResult Validate()
        {
            if (string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(LastName) ||
                string.IsNullOrWhiteSpace(Gender))
            {
                return OperationResult.Failed("One field is empty");
            }

            if (!ValidateNationalId(NationalId))
            {
                return OperationResult.Failed("National Code format is incorrect");
            }
 
            string genderLower = Gender.ToLower().Trim();
            if (genderLower != "man" && genderLower != "woman")
            {
                return OperationResult.Failed("Please select a correct Gender");
            }

            return OperationResult.Success();
        }


    }


}
