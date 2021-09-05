using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class FindCommand : Command
    {
        public FindCommand(Repository repository, string[] param) : base(repository, param)
        {

        }
        public override string Execute()
        {
            Student[] student = repository.Find(param[0]);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < student.Length; i++)
            {
                sb.AppendLine(student[i].ToString());
            }
            return sb.ToString();
        }
    }
}
