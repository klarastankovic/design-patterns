using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Members
{
    public static class MembersTester
    {
        public static void Test()
        {
            List<IQuestMember> questMembers = new List<IQuestMember>();
            Player conan = new Player("Conan", new Damage(100, 0));
            Player gandalf = new Player("Gandalf", new Damage(5, 100));
            Party bridgeburners = new Party("Bridgeburners");
            bridgeburners.AddMember(new Player("Whiskeyjack", new Damage(50, 0)));
            Party mages = new Party("Mages");
            mages.AddMember(new Player("Hedge", new Damage(20, 70)));
            bridgeburners.AddMember(mages);
            questMembers.Add(conan);
            questMembers.Add(gandalf);
            questMembers.Add(bridgeburners);
            Damage totalDamage = new Damage();
            foreach(IQuestMember member in questMembers)
            {
                totalDamage += member.TotalDamage;
                Console.WriteLine(member.Name);
            }
            Console.WriteLine("Total damage done: " + totalDamage);
        }
    }
}
