using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.UsersToFiles
{
    public class CSVWriter : IUserWriter
    {
        private string filename;
        bool append = true;
        public CSVWriter(string filename) { this.filename = filename; }
        public void WriteUser(User user)
        {
            using(System.IO.StreamWriter writer = new System.IO.StreamWriter(filename, append)) {
                writer.WriteLine(this.UserToCsv(user));
            }
        }
        private String UserToCsv(User user)
        {
            return user.Name + ","+ user.Surname + "," + user.Phone + "," + user.Mail;
        }
    }
}
