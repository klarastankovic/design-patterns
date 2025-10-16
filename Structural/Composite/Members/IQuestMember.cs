using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Members
{
    public interface IQuestMember
    {
        String Name { get; }
        Damage TotalDamage { get; }
    }
}
