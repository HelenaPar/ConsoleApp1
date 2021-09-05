using ConsoleApp1.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    public abstract class Command
    {
        protected string[] parameters;
        protected Repository repository;
        protected IValidator validator;

        internal string ExecuteWithValidation()
        { 
           if(validator != null)
           {
                if (validator.Validate())
                {
                    return Execute();
                }
                return validator.ErrorMessage;
           }
            return Execute();
        }
        public Command(Repository repository, string[] parameters)
        {
            this.parameters = parameters;
            this.repository = repository;
        }

        public abstract string Execute();
    }
}
