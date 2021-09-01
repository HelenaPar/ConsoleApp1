using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class EditCommand : Command
    {
        public EditCommand(Repository repository, string[] param) : base(repository, param)
        {
            
        }
        public override string Execute()
        {
           Student student = new Student(Convert.ToInt32(param[0]), param[1], param[2], param[3], Convert.ToInt32(param[4]));
           bool a = repository.EditAll(student);
           switch(a)
            {
                case true:
                    return "Запись успешно изменена!";
                case false:
                    return "Запись не изменена!";
            }
           
        }
    }
}
