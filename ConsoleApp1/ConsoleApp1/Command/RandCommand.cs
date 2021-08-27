using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class RandCommand : Command
    {
        public RandCommand(Repository repository, string[] param) : base(repository, param)
        {

        }
        public override string Execute()
        {            return repository.Rand();
        }
    }
}
