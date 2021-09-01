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
            bool a = repository.Delete(Convert.ToInt32(this.param[0]));
            switch (a)
            {
                case true:
                    return "Запись успешно удалена";
                case false:
                    return "Запись не удалена!";
            }
            
        }
    }
}
