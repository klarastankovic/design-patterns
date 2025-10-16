﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Validator
{
    public class UserEntry // fasada
    {
        public String Email { get; set; }
        public String Password { get; set; }
        private UserEntry() { }
        public static UserEntry ReadUserFromConsole()
        {
            UserEntry entry = new UserEntry();
            Console.WriteLine("Enter email: ");
            entry.Email = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            entry.Password = Console.ReadLine();
            return entry;
        }
    }
}
