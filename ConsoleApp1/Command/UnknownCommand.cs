using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class UnknownCommand : Command
    {
        public UnknownCommand(Repository repository, string[] param) : base(repository, param)
        {

        }

        public override string Execute()
        {
            return "Вы ввели неизвестную команду!";
        }
    }
}
