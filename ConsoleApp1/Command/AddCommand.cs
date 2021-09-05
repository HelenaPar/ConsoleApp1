using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class AddCommand : Command
    {
        public AddCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
          
        }

        public override string Execute()
        {
            Student student = new Student(Convert.ToInt32(this.param[0]), this.param[1], this.param[2], this.param[3], Convert.ToInt32(this.param[4]));
            int result = repository.Add(student);
            return result == 0 ? "Запись не добавлена!" : "Запись успешно добавлена!";
        }
        
    }

}
