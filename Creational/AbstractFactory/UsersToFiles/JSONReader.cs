using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class JSONReader : IUserReader
    {
        string filename;
        public JSONReader(string filename) { this.filename = filename; }
        public IList<User> ReadAllUsers()
        {
            // implementation
            return new List<User>();
        }
    }
}
