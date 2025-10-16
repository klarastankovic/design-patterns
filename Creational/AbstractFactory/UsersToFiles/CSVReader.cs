using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class CSVReader : IUserReader
    {
        private char[] splitTokens = new [] { ',' };
        private string filename;
        public CSVReader(string filename) { this.filename = filename; }
        public IList<User> ReadAllUsers()
        {
            List<User> users = new List<User>();
            List<String> csvLines = this.ReadAllLines();
            foreach (String line in csvLines)
            {
                users.Add(this.ParseUserFromCSV(line));
            }
            return users;
        }
        private List<String> ReadAllLines()
        {
            List<String> lines = new List<string>();
            lines.AddRange(System.IO.File.ReadAllLines(this.filename));
            return lines;
        }
        private User ParseUserFromCSV(String line)
        {
            String[] parts = line.Split(this.splitTokens);
            return new User(parts[0], parts[1], parts[2], parts[3]);
        }
    }
}
