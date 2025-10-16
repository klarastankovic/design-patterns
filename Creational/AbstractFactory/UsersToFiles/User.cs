using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class User
    {
        public String Name { get; private set; }
        public String Surname { get; private set; }
        public String Phone { get; private set; }
        public String Mail { get; private set; }
        public User(string name, string surname, string phone, string mail)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Mail = mail;
        }
        public override String ToString()
        {
            return Surname + "," + Name + Environment.NewLine
                + "\ttel: " + Phone + Environment.NewLine
                + "\tmail: " + Mail + Environment.NewLine;
        }
    }
}
