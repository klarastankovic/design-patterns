using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public interface IUserReader
    {
        IList<User> ReadAllUsers();
    }
}
