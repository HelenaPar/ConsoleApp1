using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    public class Command
    {
        private string[] param;
        protected Repository repository;
        public Command(Repository repository, string[] param)
        {
            this.param = param;
            this.repository = repository;
        }

        public virtual string Execute()
        {
            return "nothing";
        }
    }
}
