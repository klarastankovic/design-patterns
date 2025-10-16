using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Members
{
    public class Player : IQuestMember
    {
        public String Name { get; private set; }
        public Damage TotalDamage { get; private set; }
        public Player(string name, Damage damage)
        {
            Name = name;
            TotalDamage = damage;
        }
    }
}
