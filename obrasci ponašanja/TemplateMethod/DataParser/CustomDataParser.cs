using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DataParser
{
    public class CustomDataParser : DataParser
    {
        protected override List<User> Parse(List<String> rawData)
        {
            List<User> users = new List<User>();
            foreach(String item in rawData)
            {
                User user = ParseUsersFrom(item);
                users.Add(user);
            }
            return users;
        }
        private User ParseUsersFrom(String item)
        {
            char[] charsToTrim = new char[] { '[', ']' };
            String[] parts = item.Split(',');
            String id = parts[0].Trim(charsToTrim);
            String name = parts[1];
            return new User(id, name);
        }
    }
}
