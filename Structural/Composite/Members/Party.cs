using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Members
{
    public class Party : IQuestMember
    {
        List<IQuestMember> partyMembers;
        public String Name {get; set;}
        public Party(String name)
        {
            this.Name = name;
            this.partyMembers = new List<IQuestMember>();
        }
        public void AddMember(IQuestMember member)
        {
            this.partyMembers.Add(member);
        }
        public Damage TotalDamage
        {
            get
            {
                Damage totalDamage = new Damage();
                foreach (IQuestMember member in this.partyMembers)
                {
                    totalDamage += member.TotalDamage;
                }
                return totalDamage;
            }
        }
    }
}
