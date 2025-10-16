using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primjeri.Singleton
{
    class TS_DatabaseHelper
    {
        // Private static reference, will hold the only instance:
        private static TS_DatabaseHelper instance;
        //Locking mechanism:
        private static readonly object padlock = new object();
        // The constructor should be private:
        private TS_DatabaseHelper()
        {
            // Some real code, connectin to the DB and so on
            // ...
        }
        // A single access point:
        public static TS_DatabaseHelper GetInstance()
        {
            lock (padlock)
            {
                // Lazy instantantion:
                if (instance == null)
                {
                    instance = new TS_DatabaseHelper();
                }
                return instance;
            }
        }

        public List<User> RetrieveAllUsers()
        {
            List<User> users = new List<User>();
            // Actually query the DB for users
            // Load the results into the list
            return users;
        }
    }
}
