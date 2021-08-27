using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] param) : base(repository, param)
        {

        }
        public override string Execute()
        {
            return repository.Find(param[0], param[1]);
        }
    }
}
