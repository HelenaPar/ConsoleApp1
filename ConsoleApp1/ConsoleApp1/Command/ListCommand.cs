using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class ListCommand : Command
    {
        Student student;
        public ListCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {

        }
        public override string Execute() //я туплю, на сайте то много информации..
        {            //но как корректно действовать в этом случае я не понимаю, мне нужен пример :')
            StringBuilder sb = new StringBuilder();
           Student[] stud = repository.List();
           for(int i = 0; i < stud.Length; i++)
            {
                stud.ToString();
                sb.AppendLine(stud.ToString());
            }
            string s1 = sb.ToString();
            return s1; 


        }
    }
}
