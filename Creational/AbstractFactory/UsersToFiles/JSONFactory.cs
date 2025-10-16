using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class JSONFactory : IFileFactory
    {
        public IUserReader CreateReader(string filename) { return new JSONReader(filename); }
        public IUserWriter CreateWriter(string filename) { return new JSONWriter(filename); }
    }
}
