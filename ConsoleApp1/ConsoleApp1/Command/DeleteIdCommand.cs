using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class DeleteCommand : Command
    {
        public DeleteCommand(Repository repository, string[] param) : base(repository, param)
        {
            
        }
        public override string Execute()
        {
            repository.Delete(Convert.ToInt32(this.param[0]));
            return "Запись успешно удалена";
        }
    }
}
