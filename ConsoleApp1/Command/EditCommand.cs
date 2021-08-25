using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class EditCommand : Command
    {
        public EditCommand(Repository repository, string[] param) : base(repository, param)
        {
            repository.EditAll(Convert.ToInt32(param[0]), param[1], param[2], param[3], Convert.ToInt32(param[4]));
        }
        public override string Execute()
        {
            return "Запись успешно изменена!";
        }
    }
}
