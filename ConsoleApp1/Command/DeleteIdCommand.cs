using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class DeleteIdCommand : Command
    {
        public DeleteIdCommand(Repository repository, string[] param) : base(repository, param)
        {
            repository.Delete(Convert.ToInt32(param[0]));
        }
        public override string Execute()
        {
            return "Запись успешно удалена!";
        }
    }
}
