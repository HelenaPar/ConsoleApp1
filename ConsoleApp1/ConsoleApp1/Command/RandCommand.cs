using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class RandCommand : Command
    {
        Student stud;
        public RandCommand(Repository repository, string[] param) : base(repository, param)
        {

        }
        public override string Execute()
        {
            Student[] student = repository.List();
            Random rnd = new Random();
            int value = rnd.Next(0, student.Length);
            for (int i = 0; i < student.Length; i++)
            {
                stud = student[value];
            }
            return stud.ToString();
        }
    }
}
