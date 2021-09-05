using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class ListCommand : Command
    {
        public ListCommand(Repository repository, string[] parametrs) : base(repository, parametrs)
        {

        }
        public override string Execute() 
        {          
           StringBuilder sb = new StringBuilder();
           Student[] student = repository.List();
           for(int i = 0; i < student.Length; i++)
            {
                sb.AppendLine(student[i].ToString());
            }
            return sb.ToString(); 
        }
    }
}
