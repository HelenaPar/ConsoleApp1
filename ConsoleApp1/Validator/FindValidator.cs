using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Validator
{
    class FindValidator : BaseValidator
    {
        public FindValidator(string[] parameters) : base(parameters)
        {

        }
        public override bool Validate()
        {
            return ValidateNameOrSurname(parameters[0]);
        }
    }
}
