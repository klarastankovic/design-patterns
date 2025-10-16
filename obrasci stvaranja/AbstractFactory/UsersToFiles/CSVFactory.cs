using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class CSVFactory : IFileFactory
    {
        public IUserReader CreateReader(string filename) { return new CSVReader(filename); }
        public IUserWriter CreateWriter(string filename) { return new CSVWriter(filename); }
    }
}
