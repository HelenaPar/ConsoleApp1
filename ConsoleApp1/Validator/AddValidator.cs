using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Validator
{
    class AddValidator : BaseValidator
    {
        public AddValidator(string[] parameters) : base(parameters)
        {

        }
        public override bool Validate()
        {
            bool name = ValidateNameOrSurname(parameters[1]);
            bool surname = ValidateNameOrSurname(parameters[2]);
            bool gen = ValidateGender(parameters[3]);
            bool age = ValidateAge(parameters[4]);
            if (name == true && surname == true && gen == true && age == true)
            {
                return true;
            }
            return false;
        }
    }
}
