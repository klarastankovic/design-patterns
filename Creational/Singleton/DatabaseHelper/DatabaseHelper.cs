using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.DatabaseHelper
{
    public class DatabaseHelper
    {
        private static DatabaseHelper instance;
        private DatabaseHelper() { }
        public static DatabaseHelper GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseHelper();
            }
            return instance;
        }
        public List<User> RetrieveAllUsers()
        {
            List<User> users = new List<User>();
            // Actually quary the DB for users
            // Load the results into the list
            return users;
        }
    }
}
