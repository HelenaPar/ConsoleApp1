using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class AddCommand : Command
    {
        public AddCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
           // student = new Student(Convert.ToInt32(parametrs[0]), parametrs[1], parametrs[2], parametrs[3], Convert.ToInt32(parametrs[4]));
           // repository.Add(Convert.ToInt32(parametrs[0]), student);
            //repository.List();
        }

        public override string Execute()
        {
            Student student = new Student(Convert.ToInt32(this.param[0]), this.param[1], this.param[2], this.param[3], Convert.ToInt32(this.param[4]));
            repository.Add(student);
            return "Запись успешно добавлена!";
        }
        
    }

}
