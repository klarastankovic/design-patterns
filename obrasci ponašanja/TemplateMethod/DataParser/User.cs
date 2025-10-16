using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.DataParser
{
    public class User
    {
        public String Name { get; set; }
        public String ID { get; set; }
        public User(String id, String name)
        {
            this.Name = name;
            this.ID = id;
        }
    }
}
