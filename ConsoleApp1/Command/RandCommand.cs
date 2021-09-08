﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class RandCommand : Command
    {
        Student stud;
        public RandCommand(Repository repository, string[] parameters) : base(repository, parameters)
        {

        }
        public override string Execute()
        {
            Student[] student = repository.List();
            Random rnd = new Random();
            int value = rnd.Next(0, student.Length);
            return student[value].ToString();
        }
    }
}
