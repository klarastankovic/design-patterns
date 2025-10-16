using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DataParser
{
    public abstract class DataParser
    {
        public void DisplayData(String path) //metoda predlozak
        {
            List<String> rawData = this.ReadData(path);
            List<User> users = this.Parse(rawData);
            this.PrintDataToConsole(users);
        }
        private List<String> ReadData(String path)
        {
            return File.ReadAllLines(path).ToList();
        }
        protected abstract List<User> Parse(List<String> rawData);
        protected virtual void PrintDataToConsole(IList<User> users)
        {
            foreach(User user in users)
            {
                Console.WriteLine("[" + user.ID + "]: " + user.Name );
            }
        }
    }
}
