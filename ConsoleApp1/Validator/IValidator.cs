using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Validator
{
    public interface IValidator
    {
        public bool Validate();
        public string ErrorMessage { get; set; }
    }
}
