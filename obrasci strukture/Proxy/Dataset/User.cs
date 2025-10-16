using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Dataset
{
    public class User
    {
        private static int id = 0;
        public string Name { get; private set; }
        public int ID { get; private set; }
        private User(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }
        public static User GenerateUser(string name)
        {
            id++;
            return new User(name, id);
        }
    }
}
