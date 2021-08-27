﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Command
{
    class GetCommand : Command
    {
        public GetCommand(Repository repository, string[] param) : base(repository, param)
        {
            
        }
        public override string Execute()
        {
            return repository.GetId(Convert.ToInt32(this.param[0]));
        }
    }
}
