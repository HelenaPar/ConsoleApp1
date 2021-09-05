using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Validator
{
    public abstract class BaseValidator : IValidator
    {
        public string ErrorMessage { get; set; }
        protected readonly string[] parameters;
        protected BaseValidator(string[] parameters)
        {
            this.parameters = parameters;
        }

        public abstract bool Validate();

        protected bool ValidateId(string id)
        {
            if (int.TryParse(id, out var result))
            {
                return true;
            }
            ErrorMessage += "Wrong id!\n";
            return false;
        }
       
        protected bool ValidateNameOrSurname(string namOrsur) 
        { //один метод на два параметра, так как требования к ним в принципе одинаковые
            foreach (var symbol in namOrsur)
            {
                if (namOrsur.Length < 50)
                {
                    if (!char.IsDigit(symbol))
                    {
                        return true;
                    }
                }
            }
            ErrorMessage += "Wrong name or surname!\n";
            return false;
        }
        protected bool ValidateAge(string age)
        {
            int Age = int.Parse(age);
            if (Age > 18 && Age < 99)
            {
                return true;
            }
            ErrorMessage += "Wrong age!\n";
            return false;
        }
        protected bool ValidateGender(string gender)
        {
            if(gender == "М" || gender == "Ж" || gender == "муж" || gender == "жен" || gender == "мужской" || gender == "женский")
            {
                return true;
            }
            ErrorMessage += "Wrong gender!\n";
            return false;
        }
    }
}
