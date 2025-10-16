using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class Client
    {
        private IFileFactory factory;
        public Client(IFileFactory factory) { this.factory = factory; }
        public void RunBussinesLogic()
        {
            User klara = new User("Klara", "Stankovic", "0123456", "klara.stankovic@ferit.hr");
            String filename = "users";
            IUserWriter writer = factory.CreateWriter(filename);
            IUserReader reader = factory.CreateReader(filename);
            writer.WriteUser(klara);
            IList<User> users = reader.ReadAllUsers();
            foreach (User user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
