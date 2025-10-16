using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public interface IFileFactory
    {
        IUserReader CreateReader(string filename);
        IUserWriter CreateWriter(string filename);
    }
}
