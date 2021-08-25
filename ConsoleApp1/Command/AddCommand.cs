using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class AddCommand : Command
    {
        Student student;
        public AddCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {
            student = new Student(Convert.ToInt32(parametrs[0]), parametrs[1], parametrs[2], parametrs[3], Convert.ToInt32(parametrs[4]));
            repository.Add(Convert.ToInt32(parametrs[0]), student);
            //repository.List();
        }

        public override string Execute()
        {
            // return repository.Add(student);
            return "Запись успешно добавлена!"; 

        }
        
    }

}
