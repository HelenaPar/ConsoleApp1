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
            bool result = repository.Delete(Convert.ToInt32(this.param[0]));
            return result == true ? "Запись успешно удалена!" : "Запись не удалена!";
        }
    }
}
