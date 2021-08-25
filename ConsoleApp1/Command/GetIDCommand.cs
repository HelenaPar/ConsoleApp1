using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class GetIDCommand : Command
    {
        
        public GetIDCommand(Repository repository, string[] param) : base(repository, param)
        {
            repository.GetId(Convert.ToInt32(param[0]));
        }
        public override string Execute()
        {
            return "Найдена запись...";
        }
    }
}
