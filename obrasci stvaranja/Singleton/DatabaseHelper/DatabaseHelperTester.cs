using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.DatabaseHelper
{
    public static class DatabaseHelperTester
    {
        public static void Test()
        {
            DatabaseHelper helper = DatabaseHelper.GetInstance();
            List<User> users = helper.RetrieveAllUsers();
        }
    }
}
