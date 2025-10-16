using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class JSONWriter : IUserWriter
    {
        string filename;
        public JSONWriter(string filename) { this.filename = filename; }
        public void WriteUser(User user)
        {

        }
    }
}
