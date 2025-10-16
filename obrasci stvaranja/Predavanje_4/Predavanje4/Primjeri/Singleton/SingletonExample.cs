using Primjeri.Utilities;
using System;
using System.Collections.Generic;

namespace Primjeri.Singleton
{
    class SingletonExample : IExample
    {
        public string Name
        {
            get
            {
                return this.ToString();
            }
        }

        public void Run()
        {
            DatabaseHelper helper = DatabaseHelper.GetInstance();
            List<User> users = helper.RetrieveAllUsers();

            TS_DatabaseHelper TS_helper = TS_DatabaseHelper.GetInstance();
            users = helper.RetrieveAllUsers();
        }
    }
}
