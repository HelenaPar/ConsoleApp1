using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    public class CommandParser
    {
        private Repository repository;

        public CommandParser(Repository repository)
        {
            this.repository = repository;
        }

        public Command Parse(string input)
        {
            var inputArr = input.Split();
            string[] param = new string[6];
            int index = 0;
            foreach(var item in inputArr)
            {
                if(!string.IsNullOrEmpty(item) && index < param.Length && item != inputArr[0])
                {
                    param[index] = item;
                    index++;
                }
            }
            switch(inputArr[0].ToUpper())
            {
                case "ADD":
                    return new AddCommand(repository, param);
                case "EDIT":
                    return new EditCommand(repository, param);
                case "GET":
                    return new GetCommand(repository, param);
                case "DELETE":
                    return new DeleteCommand(repository, param);
                case "LIST":
                    return new ListCommand(repository, param);
                case "RAND":
                    return new RandCommand(repository, param);
                case "FIND":
                    return new FindCommand(repository, param);
                default:
                    return new UnknownCommand(repository, parameters);

            }
        }
    }
}
